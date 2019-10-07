using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public class Audit
	{
		string _rootPath = "/app/rest/2018.1/audit";
		IServerConnection _serverConnection;

		public Audit(IServerConnection connection)
		{
			_serverConnection = connection;
		}

		/// <summary>
		/// 
		/// </summary>
		public async Task<HttpResponseMessage> GET_get(string locator, string fields)
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
		public async Task<HttpResponseMessage> GET_getSingle_auditEventLocator(string fields, string auditEventLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{auditEventLocator}";
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