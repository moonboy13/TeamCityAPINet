using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public class ProblemsConnector
	{
		string _rootPath = "/app/rest/2018.1/problems";
		IServerConnection _serverConnection;

		public ProblemsConnector(IServerConnection connection)
		{
			_serverConnection = connection;
		}

		/// <summary>
		/// Experimental, the requests and results returned will change in future versions!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getProblems(string locator, string fields)
		{
			string uriParams = string.Empty;
			string subUri = string.Empty;
			if(locator != string.Empty)
			{
				uriParams += locator;
			}
			if(fields != string.Empty)
			{
				uriParams += fields;
			}
			string requestURI = _rootPath + subUri;
			if(uriParams != string.Empty)
			{
				requestURI += uriParams;
			}
			HttpResponseMessage response = await _serverConnection.MakeRequest(WebUtility.UrlEncode(requestURI));
			if (!response.IsSuccessStatusCode)
			{
				throw new HttpRequestException(response.ReasonPhrase);
			}
			return response;
		}

		/// <summary>
		/// 
		/// </summary>
		public async Task<HttpResponseMessage> GET_serveInstance_problemLocator(string fields, string problemLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{problemLocator}";
			if(fields != string.Empty)
			{
				uriParams += fields;
			}
			string requestURI = _rootPath + subUri;
			if(uriParams != string.Empty)
			{
				requestURI += uriParams;
			}
			HttpResponseMessage response = await _serverConnection.MakeRequest(WebUtility.UrlEncode(requestURI));
			if (!response.IsSuccessStatusCode)
			{
				throw new HttpRequestException(response.ReasonPhrase);
			}
			return response;
		}

	}
}