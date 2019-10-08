using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public class ChangesConnector
	{
		string _rootPath = "/app/rest/2018.1/changes";
		IServerConnection _serverConnection;

		public ChangesConnector(IServerConnection connection)
		{
			_serverConnection = connection;
		}

		/// <summary>
		/// Lists changes by the specified locator
		/// </summary>
		public async Task<HttpResponseMessage> GET_serveChanges(string project, string buildType, string build, string vcsRoot, string sinceChange, long? start, int? count, string locator, string fields)
		{
			string uriParams = string.Empty;
			string subUri = string.Empty;
			if(project != string.Empty)
			{
				uriParams += project;
			}
			if(buildType != string.Empty)
			{
				uriParams += buildType;
			}
			if(build != string.Empty)
			{
				uriParams += build;
			}
			if(vcsRoot != string.Empty)
			{
				uriParams += vcsRoot;
			}
			if(sinceChange != string.Empty)
			{
				uriParams += sinceChange;
			}
			if(start != null)
			{
				uriParams += start.ToString();
			}
			if(count != null)
			{
				uriParams += count.ToString();
			}
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
		/// Experimental support only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getChangeParentRevisions_changeLocator_parentRevisions(string changeLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{changeLocator}/parentRevisions";
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
		/// Experimental support only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getRelatedBuildTypes_changeLocator_buildTypes(string fields, string changeLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{changeLocator}/buildTypes";
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
		/// Experimental support only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getChangeVCSRootInstance_changeLocator_vcsRootInstance(string fields, string changeLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{changeLocator}/vcsRootInstance";
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
		/// Experimental support only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getChangeFirstBuilds_changeLocator_firstBuilds(string fields, string changeLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{changeLocator}/firstBuilds";
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
		/// Experimental support only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getChangeDuplicates_changeLocator_duplicates(string fields, string changeLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{changeLocator}/duplicates";
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
		/// Experimental support only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getChangeAttributes_changeLocator_attributes(string fields, string changeLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{changeLocator}/attributes";
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
		public async Task<HttpResponseMessage> GET_serveChange_changeLocator(string fields, string changeLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{changeLocator}";
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
		public async Task<HttpResponseMessage> GET_getChangeField_changeLocator_field(string changeLocator, string field)
		{
			string uriParams = string.Empty;
			string subUri = $"/{changeLocator}/{field}";
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
		/// Experimental support only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getParentChanges_changeLocator_parentChanges(string fields, string changeLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{changeLocator}/parentChanges";
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
		public async Task<HttpResponseMessage> GET_getChangeVCSRoot_changeLocator_vcsRoot(string fields, string changeLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{changeLocator}/vcsRoot";
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
		/// Experimental support only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getChangeIssue_changeLocator_issues(string changeLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{changeLocator}/issues";
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