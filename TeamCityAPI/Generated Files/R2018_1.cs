using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public class R2018_1Connector
	{
		string _rootPath = "/app/rest/2018.1";
		IServerConnection _serverConnection;

		public R2018_1Connector(IServerConnection connection)
		{
			_serverConnection = connection;
		}

		/// <summary>
		/// 
		/// </summary>
		public async Task<HttpResponseMessage> GET_serveRoot()
		{
			string uriParams = string.Empty;
			string subUri = string.Empty;
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
		public async Task<HttpResponseMessage> GET_serveVersion_version()
		{
			string uriParams = string.Empty;
			string subUri = $"/version";
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
		public async Task<HttpResponseMessage> GET_serveApiVersion_apiVersion()
		{
			string uriParams = string.Empty;
			string subUri = $"/apiVersion";
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
		public async Task<HttpResponseMessage> GET_servePluginInfo_info(string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/info";
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
		public async Task<HttpResponseMessage> GET_serveBuildFieldShort_projectLocator_btLocator_buildLocator_field(string projectLocator, string btLocator, string buildLocator, string field)
		{
			string uriParams = string.Empty;
			string subUri = $"/{projectLocator}/{btLocator}/{buildLocator}/{field}";
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