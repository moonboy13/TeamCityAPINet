using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public class Server
	{
		string _rootPath = "/app/rest/2018.1/server";
		IServerConnection _serverConnection;

		public Server(IServerConnection connection)
		{
			_serverConnection = connection;
		}

		/// <summary>
		/// 
		/// </summary>
		public async Task<HttpResponseMessage> GET_serveServerInfo(string fields)
		{
			string uriParams = string.Empty;
			string subUri = string.Empty;
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
		public async Task<HttpResponseMessage> GET_servePlugins_plugins(string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/plugins";
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
		public async Task<HttpResponseMessage> DELETE_deleteLicenseKey_licensingData_licenseKeys_licenseKey(string licenseKey)
		{
			string uriParams = string.Empty;
			string subUri = $"/licensingData/licenseKeys/{licenseKey}";
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
		public async Task<HttpResponseMessage> GET_getLicenseKey_licensingData_licenseKeys_licenseKey(string fields, string licenseKey)
		{
			string uriParams = string.Empty;
			string subUri = $"/licensingData/licenseKeys/{licenseKey}";
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
		public async Task<HttpResponseMessage> GET_getLicensingData_licensingData(string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/licensingData";
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
		/// Adds newline-delimited list of license keys to the server or returns textual description is there are not valid keys
		/// </summary>
		public async Task<HttpResponseMessage> POST_addLicenseKeys_licensingData_licenseKeys(string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/licensingData/licenseKeys";
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
		public async Task<HttpResponseMessage> GET_getLicenseKeys_licensingData_licenseKeys(string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/licensingData/licenseKeys";
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
		public async Task<HttpResponseMessage> GET_getBackupStatus_backup()
		{
			string uriParams = string.Empty;
			string subUri = $"/backup";
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
		public async Task<HttpResponseMessage> POST_startBackup_backup(string fileName, bool? addTimestamp, bool? includeConfigs, bool? includeDatabase, bool? includeBuildLogs, bool? includePersonalChanges, bool? includeRunningBuilds, bool? includeSupplimentaryData)
		{
			string uriParams = string.Empty;
			string subUri = $"/backup";
			if(fileName != string.Empty)
			{
				uriParams += fileName;
			}
			if(addTimestamp != null)
			{
				uriParams += addTimestamp.ToString();
			}
			if(includeConfigs != null)
			{
				uriParams += includeConfigs.ToString();
			}
			if(includeDatabase != null)
			{
				uriParams += includeDatabase.ToString();
			}
			if(includeBuildLogs != null)
			{
				uriParams += includeBuildLogs.ToString();
			}
			if(includePersonalChanges != null)
			{
				uriParams += includePersonalChanges.ToString();
			}
			if(includeRunningBuilds != null)
			{
				uriParams += includeRunningBuilds.ToString();
			}
			if(includeSupplimentaryData != null)
			{
				uriParams += includeSupplimentaryData.ToString();
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
		public async Task<HttpResponseMessage> GET_serveServerVersion_field(string field)
		{
			string uriParams = string.Empty;
			string subUri = $"/{field}";
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
		public async Task<HttpResponseMessage> GET_getRoot_files_areaId(string basePath, string locator, string fields, string areaId)
		{
			string uriParams = string.Empty;
			string subUri = $"/files/{areaId}";
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
		public async Task<HttpResponseMessage> GET_getContent_files_areaId_contentpath(string responseBuilder, string areaId, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/files/{areaId}/content{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getChildren_files_areaId_childrenpath(string basePath, string locator, string fields, string areaId, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/files/{areaId}/children{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getMetadata_files_areaId_metadatapath(string fields, string areaId, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/files/{areaId}/metadata{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getChildrenAlias_files_areaIdpath(string basePath, string locator, string fields, string areaId, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/files/{areaId}{path:(.*)?}";
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
		public async Task<HttpResponseMessage> GET_getContentAlias_files_areaIdfilespath(string areaId, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/files/{areaId}files{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getZipped_files_areaId_archivedpath(string basePath, string locator, string name, string areaId, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/files/{areaId}/archived{path:(/.*)?}";
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