using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public class Agents
	{
		string _rootPath = "/app/rest/2018.1/agents";
		IServerConnection _serverConnection;

		public Agents(IServerConnection connection)
		{
			_serverConnection = connection;
		}

		/// <summary>
		/// Returns list of agents
		/// </summary>
		public async Task<HttpResponseMessage> GET_serveAgents(bool? includeDisconnected, bool? includeUnauthorized, string locator, string fields)
		{
			string uriParams = string.Empty;
			string subUri = string.Empty;
			if(includeDisconnected != null)
			{
				uriParams += includeDisconnected.ToString();
			}
			if(includeUnauthorized != null)
			{
				uriParams += includeUnauthorized.ToString();
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
		public async Task<HttpResponseMessage> GET_serveAgent_agentLocator(string fields, string agentLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{agentLocator}";
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
		public async Task<HttpResponseMessage> DELETE_deleteAgent_agentLocator(string agentLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{agentLocator}";
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
		public async Task<HttpResponseMessage> GET_getEnabledInfo_agentLocator_enabledInfo(string fields, string agentLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{agentLocator}/enabledInfo";
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
		public async Task<HttpResponseMessage> PUT_setEnabledInfo_agentLocator_enabledInfo(string fields, string agentLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{agentLocator}/enabledInfo";
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
		public async Task<HttpResponseMessage> GET_serveAgentField_agentLocator_field(string agentLocator, string field)
		{
			string uriParams = string.Empty;
			string subUri = $"/{agentLocator}/{field}";
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
		public async Task<HttpResponseMessage> PUT_setAgentField_agentLocator_field(string agentLocator, string field)
		{
			string uriParams = string.Empty;
			string subUri = $"/{agentLocator}/{field}";
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
		public async Task<HttpResponseMessage> GET_getAgentPool_agentLocator_pool(string fields, string agentLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{agentLocator}/pool";
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
		public async Task<HttpResponseMessage> PUT_setAgentPool_agentLocator_pool(string fields, string agentLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{agentLocator}/pool";
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
		/// Experimental use only
		/// </summary>
		public async Task<HttpResponseMessage> PUT_setAllowedRunConfigurations_agentLocator_compatibilityPolicy(string fields, string agentLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{agentLocator}/compatibilityPolicy";
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
		/// Experimental use only
		/// </summary>
		public async Task<HttpResponseMessage> GET_getAllowedRunConfigurations_agentLocator_compatibilityPolicy(string fields, string agentLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{agentLocator}/compatibilityPolicy";
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
		/// Experimental support to get currently incompatible build types with incompatibility reason
		/// </summary>
		public async Task<HttpResponseMessage> GET_geIncompatibleBuildTypes_agentLocator_incompatibleBuildTypes(string fields, string agentLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{agentLocator}/incompatibleBuildTypes";
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
		public async Task<HttpResponseMessage> PUT_setAuthorizedInfo_agentLocator_authorizedInfo(string fields, string agentLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{agentLocator}/authorizedInfo";
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
		public async Task<HttpResponseMessage> GET_getAuthorizedInfo_agentLocator_authorizedInfo(string fields, string agentLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{agentLocator}/authorizedInfo";
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
		/// Experimental support to get currently compatible build types
		/// </summary>
		public async Task<HttpResponseMessage> GET_getCompatibleBuildTypes_agentLocator_compatibleBuildTypes(string fields, string agentLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{agentLocator}/compatibleBuildTypes";
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