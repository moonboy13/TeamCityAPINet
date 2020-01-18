using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public class ProblemoccurrencesConnector
	{
		string _rootPath = "/app/rest/2018.1/problemOccurrences";
		IServerConnection _serverConnection;

		public ProblemoccurrencesConnector(IServerConnection connection)
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
		public async Task<HttpResponseMessage> GET_serveInstance_problemLocator(string fields, string problemLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{problemLocator}";
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