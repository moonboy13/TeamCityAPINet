using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace TCAPIGenerator
{
	class Program
	{
		#region Templates
		static string _ClassHeaderTemplate =
			"using System;" + Environment.NewLine +
			"using System.Net.Http;" + Environment.NewLine +
			"using System.Net;" + Environment.NewLine +
			"using System.Threading.Tasks;" + Environment.NewLine + Environment.NewLine +
			"namespace TeamCityAPI" + Environment.NewLine + "{{" + Environment.NewLine +
			"\tpublic class {0}" + Environment.NewLine + "\t{{" + Environment.NewLine +
			"\t\tstring _rootPath = \"{1}\";" + Environment.NewLine +
			"\t\tIServerConnection _serverConnection;" + Environment.NewLine + Environment.NewLine +
			"\t\tpublic {0}(IServerConnection connection)" + Environment.NewLine +
			"\t\t{{" + Environment.NewLine +
			"\t\t\t_serverConnection = connection;" + Environment.NewLine +
			"\t\t}}" + Environment.NewLine + Environment.NewLine;

		static string _MethodDefintionTemplate =
			"\t\t/// <summary>" + Environment.NewLine +
			"\t\t/// {0}" + Environment.NewLine +
			"\t\t/// </summary>" + Environment.NewLine +
			"\t\tpublic async Task<HttpResponseMessage> {1}({2})" + Environment.NewLine +
			"\t\t{{" + Environment.NewLine;

		static string _HttpRequestTemplate =
			"\t\t\tHttpResponseMessage response = await _serverConnection.MakeRequest(WebUtility.UrlEncode(requestURI));" + Environment.NewLine +
			"\t\t\tif (!response.IsSuccessStatusCode)" + Environment.NewLine +
			"\t\t\t{" + Environment.NewLine +
			"\t\t\t\tthrow new HttpRequestException(response.ReasonPhrase);" + Environment.NewLine +
			"\t\t\t}" + Environment.NewLine +
			"\t\t\treturn response;" + Environment.NewLine;

		static string _MethodEndTemplate = $"\t\t}}{Environment.NewLine}{Environment.NewLine}";

		static string _EndTemplate =
			"\t}" + Environment.NewLine +
			"}";
		#endregion

		#region XML Attributes
		static XName _XPATH = XName.Get("path");
		static XName _XNAME = XName.Get("name");
		static XName _XID = XName.Get("id");
		static XName _XDOC = XName.Get("doc");
		static XName _XPARAM = XName.Get("param");
		static XName _XTYPE = XName.Get("type");
		#endregion

		static string _inputFile = Path.Combine("APIDefinition", "2019.1.65998", "APIDefinition.xml");
		// TODO: Verify these. Also, if this is done right then it belongs in its own project to be consumed by the app.
		static string _modelOutput = Path.Combine("..", "..", "DataModels", "Models");
		static string _apiOutput = Path.Combine("..", "..", "TeamCityAPI");
		static TextInfo _TI = new CultureInfo("en-US", false).TextInfo;



		/// <summary>
		/// The goal here is that this helper will automadically generate the requisite TeamCity API(s) based off a provided
		/// XML file generated from the rest/app/application.wadl file.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			XElement definition = XElement.Load(_inputFile);

			var resources =
					from elem in definition.Descendants("resource")
					where !((string)elem.Attribute("path")).Trim().ToLower().Contains("swagger") &&
						elem.Parent.Name.LocalName.Trim().ToLower() == "resources"
					select elem;

			foreach (var resource in resources)
			{
				ProcessRootResource(resource);
			}
		}

		static void ProcessRootResource(XElement resource)
		{
			// Pull the root path off the resource. The last portion of this name will server as the class name.
			string path = resource.Attribute(_XPATH).Value;
			string className = _TI.ToTitleCase(path.Split('/').Last().Replace('.', '_').Replace('-', '_'));

			// Make sure the chosen class name is valid per the C# language spec.
			if (Regex.IsMatch(className, @"^\d"))
			{
				className = "R" + className;
			}
			string filePath = @"C:\Users\moonboy13\source\repos\TeamCityAPINet\TeamCityAPI\Generated Files\" + className + ".cs";

			File.WriteAllText(filePath, string.Format(_ClassHeaderTemplate, className, path));

			// First parse all the root level methods and generate a function for them.
			foreach (var method in resource.Elements("method"))
			{
				AddMethod(filePath, method);
			}

			// Next parse sub-resource nodes. Pull out the additional path element
			// and the new methods which utilize it.
			foreach (var subResorce in resource.Elements("resource"))
			{
				ProcessResource(subResorce, filePath, string.Empty);
			}

			File.AppendAllText(filePath, _EndTemplate);
		}

		static void ProcessResource(XElement resource, string filePath, string subPath)
		{
			subPath += resource.Attribute(_XPATH).Value;

			foreach (var method in resource.Elements("method"))
			{
				AddMethod(filePath, method, subPath);
			}

			foreach (var subResource in resource.Elements("resource"))
			{
				ProcessResource(subResource, filePath, subPath);
			}
		}

		static void AddMethod(string filePath, XElement methodElement, string subUri = null)
		{
			string methodName = string.Format("{0}_{1}", methodElement.Attribute(_XNAME).Value, methodElement.Attribute(_XID).Value);
			string methodDescription = methodElement.Elements(_XDOC).FirstOrDefault()?.Value.Trim() ?? string.Empty;
			var methodParameters = new StringBuilder();
			var urlParameters = new StringBuilder();
			string subUriString = string.Empty;

			// Extract the method parameters
			foreach (var paramElement in methodElement.Descendants(_XPARAM))
			{
				string paramName = paramElement.Attribute(_XNAME).Value;
				string paramType = paramElement.Attribute(_XTYPE).Value
					.Replace("xs:", string.Empty).Replace("boolean", "bool");

				if (methodParameters.Length != 0)
				{
					methodParameters.Append(", ");
				}
				// TODO: Man this is ugly
				if (paramType != "string")
				{
					methodParameters.Append(string.Format("{0}? {1}", paramType, paramName));
					urlParameters.AppendLine(string.Format("\t\t\tif({0} != null)", paramName));
					urlParameters.AppendLine("\t\t\t{");
					urlParameters.AppendLine(string.Format("\t\t\t\turiParams += {0}.ToString();", paramName));
					urlParameters.AppendLine("\t\t\t}");
				}
				else
				{
					methodParameters.Append(string.Format("{0} {1}", paramType, paramName));
					urlParameters.AppendLine(string.Format("\t\t\tif({0} != string.Empty)", paramName));
					urlParameters.AppendLine("\t\t\t{");
					urlParameters.AppendLine(string.Format("\t\t\t\turiParams += {0};", paramName));
					urlParameters.AppendLine("\t\t\t}");
				}
			}

			if (subUri != null)
			{
				subUriString = string.Format("\t\t\tstring subUri = $\"{0}\";" + Environment.NewLine, subUri);
				foreach (Match param in Regex.Matches(subUri, @"{(\w+)"))
				{
					if (methodParameters.Length != 0)
					{
						methodParameters.Append(", ");
					}

					methodParameters.Append(string.Format("string {0}", param.Groups[1].Value));
				}

				// Extend the name of the method using the subUri
				string extendedName = Regex.Replace(subUri, @"[^\w\/]", string.Empty).Replace("/", "_");
				methodName += extendedName;
			}
			else
			{
				subUriString = string.Format("\t\t\tstring subUri = string.Empty;" + Environment.NewLine);
			}

			// Write out the information to our file. Some of the methods are producing a trailing underscore character so trim adding a trim to remove that.
			File.AppendAllText(filePath, string.Format(_MethodDefintionTemplate, methodDescription, methodName.TrimEnd('_'), methodParameters.ToString()));
			File.AppendAllText(filePath, string.Format("\t\t\tstring uriParams = string.Empty;" + Environment.NewLine));
			File.AppendAllText(filePath, subUriString);
			File.AppendAllText(filePath, urlParameters.ToString());
			File.AppendAllText(filePath, "\t\t\tstring requestURI = _rootPath + subUri;" + Environment.NewLine);
			File.AppendAllText(filePath, "\t\t\tif(uriParams != string.Empty)" + Environment.NewLine);
			File.AppendAllText(filePath, "\t\t\t{" + Environment.NewLine);
			File.AppendAllText(filePath, "\t\t\t\trequestURI += uriParams;" + Environment.NewLine);
			File.AppendAllText(filePath, "\t\t\t}" + Environment.NewLine);
			File.AppendAllText(filePath, _HttpRequestTemplate);
			File.AppendAllText(filePath, _MethodEndTemplate);
		}

	}
}
