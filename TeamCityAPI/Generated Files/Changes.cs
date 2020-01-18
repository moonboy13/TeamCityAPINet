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
			if(!string.IsNullOrWhiteSpace(project))
			{
				uriParams += project;
			}
			if(!string.IsNullOrWhiteSpace(buildType))
			{
				uriParams += buildType;
			}
			if(!string.IsNullOrWhiteSpace(build))
			{
				uriParams += build;
			}
			if(!string.IsNullOrWhiteSpace(vcsRoot))
			{
				uriParams += vcsRoot;
			}
			if(!string.IsNullOrWhiteSpace(sinceChange))
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
			if(!string.IsNullOrWhiteSpace(locator))
			{
				uriParams += locator;
			}
			if(!string.IsNullOrWhiteSpace(fields))
			{
				uriParams += fields;
			}
			string requestURI = _rootPath + subUri;
			if(!string.IsNullOrWhiteSpace(uriParams))
			{
				requestURI += WebUtility.UrlEncode(uriParams);
			}
			HttpResponseMessage response = await _serverConnection.MakeRequest(requestURI).ConfigureAwait(false);
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
			if(!string.IsNullOrWhiteSpace(uriParams))
			{
				requestURI += WebUtility.UrlEncode(uriParams);
			}
			HttpResponseMessage response = await _serverConnection.MakeRequest(requestURI).ConfigureAwait(false);
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
			if(!string.IsNullOrWhiteSpace(fields))
			{
				uriParams += fields;
			}
			string requestURI = _rootPath + subUri;
			if(!string.IsNullOrWhiteSpace(uriParams))
			{
				requestURI += WebUtility.UrlEncode(uriParams);
			}
			HttpResponseMessage response = await _serverConnection.MakeRequest(requestURI).ConfigureAwait(false);
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
			if(!string.IsNullOrWhiteSpace(fields))
			{
				uriParams += fields;
			}
			string requestURI = _rootPath + subUri;
			if(!string.IsNullOrWhiteSpace(uriParams))
			{
				requestURI += WebUtility.UrlEncode(uriParams);
			}
			HttpResponseMessage response = await _serverConnection.MakeRequest(requestURI).ConfigureAwait(false);
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
			if(!string.IsNullOrWhiteSpace(fields))
			{
				uriParams += fields;
			}
			string requestURI = _rootPath + subUri;
			if(!string.IsNullOrWhiteSpace(uriParams))
			{
				requestURI += WebUtility.UrlEncode(uriParams);
			}
			HttpResponseMessage response = await _serverConnection.MakeRequest(requestURI).ConfigureAwait(false);
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
			if(!string.IsNullOrWhiteSpace(fields))
			{
				uriParams += fields;
			}
			string requestURI = _rootPath + subUri;
			if(!string.IsNullOrWhiteSpace(uriParams))
			{
				requestURI += WebUtility.UrlEncode(uriParams);
			}
			HttpResponseMessage response = await _serverConnection.MakeRequest(requestURI).ConfigureAwait(false);
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
			if(!string.IsNullOrWhiteSpace(fields))
			{
				uriParams += fields;
			}
			string requestURI = _rootPath + subUri;
			if(!string.IsNullOrWhiteSpace(uriParams))
			{
				requestURI += WebUtility.UrlEncode(uriParams);
			}
			HttpResponseMessage response = await _serverConnection.MakeRequest(requestURI).ConfigureAwait(false);
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
			if(!string.IsNullOrWhiteSpace(fields))
			{
				uriParams += fields;
			}
			string requestURI = _rootPath + subUri;
			if(!string.IsNullOrWhiteSpace(uriParams))
			{
				requestURI += WebUtility.UrlEncode(uriParams);
			}
			HttpResponseMessage response = await _serverConnection.MakeRequest(requestURI).ConfigureAwait(false);
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
			if(!string.IsNullOrWhiteSpace(uriParams))
			{
				requestURI += WebUtility.UrlEncode(uriParams);
			}
			HttpResponseMessage response = await _serverConnection.MakeRequest(requestURI).ConfigureAwait(false);
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
			if(!string.IsNullOrWhiteSpace(fields))
			{
				uriParams += fields;
			}
			string requestURI = _rootPath + subUri;
			if(!string.IsNullOrWhiteSpace(uriParams))
			{
				requestURI += WebUtility.UrlEncode(uriParams);
			}
			HttpResponseMessage response = await _serverConnection.MakeRequest(requestURI).ConfigureAwait(false);
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
			if(!string.IsNullOrWhiteSpace(fields))
			{
				uriParams += fields;
			}
			string requestURI = _rootPath + subUri;
			if(!string.IsNullOrWhiteSpace(uriParams))
			{
				requestURI += WebUtility.UrlEncode(uriParams);
			}
			HttpResponseMessage response = await _serverConnection.MakeRequest(requestURI).ConfigureAwait(false);
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
			if(!string.IsNullOrWhiteSpace(uriParams))
			{
				requestURI += WebUtility.UrlEncode(uriParams);
			}
			HttpResponseMessage response = await _serverConnection.MakeRequest(requestURI).ConfigureAwait(false);
			if (!response.IsSuccessStatusCode)
			{
				throw new HttpRequestException(response.ReasonPhrase);
			}
			return response;
		}

	}
}