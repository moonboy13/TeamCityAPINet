using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public class Vcs_Root_InstancesConnector
	{
		string _rootPath = "/app/rest/2018.1/vcs-root-instances";
		IServerConnection _serverConnection;

		public Vcs_Root_InstancesConnector(IServerConnection connection)
		{
			_serverConnection = connection;
		}

		/// <summary>
		/// 
		/// </summary>
		public async Task<HttpResponseMessage> GET_serveInstances(string locator, string fields)
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
		public async Task<HttpResponseMessage> GET_getRepositoryState_vcsRootInstanceLocator_repositoryState(string fields, string vcsRootInstanceLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/repositoryState";
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
		public async Task<HttpResponseMessage> PUT_setRepositoryState_vcsRootInstanceLocator_repositoryState(string fields, string vcsRootInstanceLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/repositoryState";
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
		public async Task<HttpResponseMessage> DELETE_deleteRepositoryState_vcsRootInstanceLocator_repositoryState(string vcsRootInstanceLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/repositoryState";
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
		public async Task<HttpResponseMessage> PUT_setInstanceField_vcsRootInstanceLocator_field(string vcsRootInstanceLocator, string field)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/{field}";
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
		public async Task<HttpResponseMessage> GET_serveInstanceField_vcsRootInstanceLocator_field(string vcsRootInstanceLocator, string field)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/{field}";
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
		public async Task<HttpResponseMessage> DELETE_deleteInstanceField_vcsRootInstanceLocator_field(string vcsRootInstanceLocator, string field)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/{field}";
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
		public async Task<HttpResponseMessage> GET_serveInstance_vcsRootInstanceLocator(string fields, string vcsRootInstanceLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}";
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
		public async Task<HttpResponseMessage> POST_scheduleCheckingForChanges_checkingForChangesQueue(string locator, string requestor, string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/checkingForChangesQueue";
			if(locator != string.Empty)
			{
				uriParams += locator;
			}
			if(requestor != string.Empty)
			{
				uriParams += requestor;
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
		public async Task<HttpResponseMessage> POST_scheduleCheckingForChanges_commitHookNotification(string locator, bool? okOnNothingFound)
		{
			string uriParams = string.Empty;
			string subUri = $"/commitHookNotification";
			if(locator != string.Empty)
			{
				uriParams += locator;
			}
			if(okOnNothingFound != null)
			{
				uriParams += okOnNothingFound.ToString();
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
		public async Task<HttpResponseMessage> GET_getRepositoryStateCreationDate_vcsRootInstanceLocator_repositoryState_creationDate(string vcsRootInstanceLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/repositoryState/creationDate";
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
		public async Task<HttpResponseMessage> GET_serveRootInstanceProperties_vcsRootInstanceLocator_properties(string fields, string vcsRootInstanceLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/properties";
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
		/// Alias
		/// </summary>
		public async Task<HttpResponseMessage> GET_getRoot_vcsRootInstanceLocator_files_latest(string basePath, string locator, string fields, string vcsRootInstanceLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/files/latest";
			if(basePath != string.Empty)
			{
				uriParams += basePath;
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
		/// 
		/// </summary>
		public async Task<HttpResponseMessage> GET_getContent_vcsRootInstanceLocator_files_latest_contentpath(string responseBuilder, string vcsRootInstanceLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/files/latest/content{path:(/.*)?}";
			if(responseBuilder != string.Empty)
			{
				uriParams += responseBuilder;
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
		public async Task<HttpResponseMessage> GET_getChildren_vcsRootInstanceLocator_files_latest_childrenpath(string basePath, string locator, string fields, string vcsRootInstanceLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/files/latest/children{path:(/.*)?}";
			if(basePath != string.Empty)
			{
				uriParams += basePath;
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
		/// 
		/// </summary>
		public async Task<HttpResponseMessage> GET_getMetadata_vcsRootInstanceLocator_files_latest_metadatapath(string fields, string vcsRootInstanceLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/files/latest/metadata{path:(/.*)?}";
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
		/// More user-friendly URL for "/artifacts/children" one.
		/// </summary>
		public async Task<HttpResponseMessage> GET_getChildrenAlias_vcsRootInstanceLocator_files_latestpath(string basePath, string locator, string fields, string vcsRootInstanceLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/files/latest{path:(.*)?}";
			if(basePath != string.Empty)
			{
				uriParams += basePath;
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
		/// More user-friendly URL for "/artifacts/children" one.
		/// </summary>
		public async Task<HttpResponseMessage> GET_getContentAlias_vcsRootInstanceLocator_files_latestfilespath(string vcsRootInstanceLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/files/latestfiles{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getZipped_vcsRootInstanceLocator_files_latest_archivedpath(string basePath, string locator, string name, string vcsRootInstanceLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{vcsRootInstanceLocator}/files/latest/archived{path:(/.*)?}";
			if(basePath != string.Empty)
			{
				uriParams += basePath;
			}
			if(locator != string.Empty)
			{
				uriParams += locator;
			}
			if(name != string.Empty)
			{
				uriParams += name;
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