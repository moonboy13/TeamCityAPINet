using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public class InvestigationsConnector
	{
		string _rootPath = "/app/rest/2018.1/investigations";
		IServerConnection _serverConnection;

		public InvestigationsConnector(IServerConnection connection)
		{
			_serverConnection = connection;
		}

		/// <summary>
		/// 
		/// </summary>
		public async Task<HttpResponseMessage> POST_createInstance(string fields)
		{
			string uriParams = string.Empty;
			string subUri = string.Empty;
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
		/// Experimental, the requests and results returned will change in future versions!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getInvestigations(string locator, string fields)
		{
			string uriParams = string.Empty;
			string subUri = string.Empty;
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
		/// 
		/// </summary>
		public async Task<HttpResponseMessage> GET_serveInstance_investigationLocator(string fields, string investigationLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{investigationLocator}";
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
		public async Task<HttpResponseMessage> PUT_replaceInstance_investigationLocator(string fields, string investigationLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{investigationLocator}";
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
		public async Task<HttpResponseMessage> DELETE_deleteInstance_investigationLocator(string investigationLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{investigationLocator}";
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> POST_createInstances_multiple(string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/multiple";
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

	}
}