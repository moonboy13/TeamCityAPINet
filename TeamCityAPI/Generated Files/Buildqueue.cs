using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public class Buildqueue
	{
		string _rootPath = "/app/rest/2018.1/buildQueue";
		IServerConnection _serverConnection;

		public Buildqueue(IServerConnection connection)
		{
			_serverConnection = connection;
		}

		/// <summary>
		/// Serves build queue.
		/// </summary>
		public async Task<HttpResponseMessage> GET_getBuilds(string locator, string fields)
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
		public async Task<HttpResponseMessage> PUT_replaceBuilds(string fields)
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
		public async Task<HttpResponseMessage> POST_queueNewBuild(bool? moveToTop)
		{
			string uriParams = string.Empty;
			string subUri = string.Empty;
			if(moveToTop != null)
			{
				uriParams += moveToTop.ToString();
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
		/// Experimental! Deletes the set of builds filtered
		/// </summary>
		public async Task<HttpResponseMessage> DELETE_deleteBuildsExperimental(string locator, string fields)
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
		public async Task<HttpResponseMessage> GET_cancelBuild_buildLocator_example_buildCancelRequest(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/example/buildCancelRequest";
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
		public async Task<HttpResponseMessage> POST_cancelBuild_queuedBuildLocator(string queuedBuildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{queuedBuildLocator}";
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
		public async Task<HttpResponseMessage> GET_getBuild_queuedBuildLocator(string fields, string queuedBuildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{queuedBuildLocator}";
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
		public async Task<HttpResponseMessage> DELETE_deleteBuild_queuedBuildLocator(string queuedBuildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{queuedBuildLocator}";
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
		public async Task<HttpResponseMessage> GET_serveTags_buildLocator_tags(string locator, string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/tags/";
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
		/// Replaces build's tags.
		/// </summary>
		public async Task<HttpResponseMessage> PUT_replaceTags_buildLocator_tags(string locator, string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/tags/";
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
		/// Adds a single tag to a build
		/// </summary>
		public async Task<HttpResponseMessage> POST_addTag_buildLocator_tags(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/tags/";
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
		/// Adds a set of tags to a build
		/// </summary>
		public async Task<HttpResponseMessage> POST_addTags_buildLocator_tags(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/tags/";
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
		/// Experimental ability to get a build at specific queue position
		/// </summary>
		public async Task<HttpResponseMessage> PUT_setBuildQueuePosition_order_queuePosition(string fields, string queuePosition)
		{
			string uriParams = string.Empty;
			string subUri = $"/order/{queuePosition}";
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
		/// Experimental ability to get a build at specific queue position
		/// </summary>
		public async Task<HttpResponseMessage> GET_setBuildQueuePosition_order_queuePosition(string fields, string queuePosition)
		{
			string uriParams = string.Empty;
			string subUri = $"/order/{queuePosition}";
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
		public async Task<HttpResponseMessage> GET_serveBuildFieldByBuildOnly_buildLocator_field(string buildLocator, string field)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/{field}";
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
		public async Task<HttpResponseMessage> GET_serveCompatibleAgents_queuedBuildLocator_compatibleAgents(string fields, string queuedBuildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{queuedBuildLocator}/compatibleAgents";
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
		/// Experimental ability to reorder the queue
		/// </summary>
		public async Task<HttpResponseMessage> PUT_setBuildQueueOrder_order(string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/order";
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