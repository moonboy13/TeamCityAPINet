using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public class BuildsConnector
	{
		string _rootPath = "/app/rest/2018.1/builds";
		IServerConnection _serverConnection;

		public BuildsConnector(IServerConnection connection)
		{
			_serverConnection = connection;
		}

		/// <summary>
		/// Serves builds matching supplied condition.
		/// </summary>
		public async Task<HttpResponseMessage> GET_serveAllBuilds(string buildType, string status, string triggeredByUser, bool? includePersonal, bool? includeCanceled, bool? onlyPinned, string tag, string agentName, string sinceBuild, string sinceDate, long? start, int? count, string locator, string fields)
		{
			string uriParams = string.Empty;
			string subUri = string.Empty;
			if(buildType != string.Empty)
			{
				uriParams += buildType;
			}
			if(status != string.Empty)
			{
				uriParams += status;
			}
			if(triggeredByUser != string.Empty)
			{
				uriParams += triggeredByUser;
			}
			if(includePersonal != null)
			{
				uriParams += includePersonal.ToString();
			}
			if(includeCanceled != null)
			{
				uriParams += includeCanceled.ToString();
			}
			if(onlyPinned != null)
			{
				uriParams += onlyPinned.ToString();
			}
			if(tag != string.Empty)
			{
				uriParams += tag;
			}
			if(agentName != string.Empty)
			{
				uriParams += agentName;
			}
			if(sinceBuild != string.Empty)
			{
				uriParams += sinceBuild;
			}
			if(sinceDate != string.Empty)
			{
				uriParams += sinceDate;
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
		/// 
		/// </summary>
		public async Task<HttpResponseMessage> DELETE_deleteBuilds(string locator)
		{
			string uriParams = string.Empty;
			string subUri = string.Empty;
			if(locator != string.Empty)
			{
				uriParams += locator;
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
		public async Task<HttpResponseMessage> POST_cancelBuild_buildLocator(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}";
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
		/// Serves a build described by the locator provided searching through those accessible by the current user. See {@link jetbrains.buildServer.server.rest.request.BuildRequest#serveAllBuilds(String, String, String, boolean, boolean, boolean, java.util.List, String, String, String, Long, Integer, String, javax.ws.rs.core.UriInfo, javax.servlet.http.HttpServletRequest)} If several builds are matched, the first one is used (the effect is the same as if ",count:1" locator dimension is added)
		/// </summary>
		public async Task<HttpResponseMessage> GET_serveBuild_buildLocator(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}";
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
		public async Task<HttpResponseMessage> DELETE_deleteBuild_buildLocator(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}";
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
		public async Task<HttpResponseMessage> GET_getCanceledInfo_buildLocator_canceledInfo(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/canceledInfo";
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
		/// Replaces the build's tags designated by the tags 'locator' to the set of tags passed.
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
		public async Task<HttpResponseMessage> POST_addTags_buildLocator_tags(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/tags/";
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
		/// Unpins a build
		/// </summary>
		public async Task<HttpResponseMessage> DELETE_unpinBuild_buildLocator_pin(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/pin/";
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
		/// Fetches current build pinned status.
		/// </summary>
		public async Task<HttpResponseMessage> GET_getPinned_buildLocator_pin(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/pin/";
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
		/// Pins a build
		/// </summary>
		public async Task<HttpResponseMessage> PUT_pinBuild_buildLocator_pin(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/pin/";
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
		public async Task<HttpResponseMessage> DELETE_deleteComment_buildLocator_comment(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/comment";
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
		public async Task<HttpResponseMessage> PUT_replaceComment_buildLocator_comment(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/comment";
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
		public async Task<HttpResponseMessage> GET_serveSourceFile_buildLocator_sources_files_fileName(string buildLocator, string fileName)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/sources/files/{fileName:.+}";
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
		/// Experimental. Pins multiple builds
		/// </summary>
		public async Task<HttpResponseMessage> PUT_pinMultiple_multiple_buildLocator_pinInfo(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/multiple/{buildLocator}/pinInfo/";
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
		/// Gets build's current pin data
		/// </summary>
		public async Task<HttpResponseMessage> GET_getPinData_buildLocator_pinInfo(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/pinInfo/";
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
		/// Sets build pin status
		/// </summary>
		public async Task<HttpResponseMessage> PUT_setBuildPinData_buildLocator_pinInfo(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/pinInfo/";
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
		/// Experimental.
		/// </summary>
		public async Task<HttpResponseMessage> DELETE_deleteMultiple_multiple_buildLocator(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/multiple/{buildLocator}";
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
		/// Experimental alias for .../app/rest/builds?locator={buildLocator}
		/// </summary>
		public async Task<HttpResponseMessage> GET_getMultiple_multiple_buildLocator(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/multiple/{buildLocator}";
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
		/// Experimental. Cancels multiple builds
		/// </summary>
		public async Task<HttpResponseMessage> POST_cancelMultiple_multiple_buildLocator(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/multiple/{buildLocator}";
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
		/// Experimental. Adds a set of tags to multiple builds
		/// </summary>
		public async Task<HttpResponseMessage> POST_addTagsMultiple_multiple_buildLocator_tags(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/multiple/{buildLocator}/tags/";
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
		/// Experimental. Deletes a set of tags from multiple builds
		/// </summary>
		public async Task<HttpResponseMessage> DELETE_removeTagsMultiple_multiple_buildLocator_tags(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/multiple/{buildLocator}/tags/";
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
		public async Task<HttpResponseMessage> GET_getParameter_buildLocator_resultingproperties_propertyName(string buildLocator, string propertyName)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/resulting-properties/{propertyName}";
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
		public async Task<HttpResponseMessage> PUT_setBuildNumber_buildLocator_number(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/number";
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
		public async Task<HttpResponseMessage> GET_getBuildNumber_buildLocator_number(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/number";
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
		public async Task<HttpResponseMessage> GET_getProblems_buildLocator_problemOccurrences(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/problemOccurrences";
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
		/// Experimental support only
		/// </summary>
		public async Task<HttpResponseMessage> GET_getArtifactsDirectory_buildLocator_artifactsDirectory(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/artifactsDirectory";
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
		public async Task<HttpResponseMessage> GET_getTests_buildLocator_testOccurrences(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/testOccurrences";
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
		/// Experimental support only
		/// </summary>
		public async Task<HttpResponseMessage> GET_getArtifactDependencyChanges_buildLocator_artifactDependencyChanges(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/artifactDependencyChanges";
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
		public async Task<HttpResponseMessage> GET_serveAggregatedBuildStatus_aggregated_buildLocator_status(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/aggregated/{buildLocator}/status";
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
		public async Task<HttpResponseMessage> GET_serveBuildStatisticValues_buildLocator_statistics(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/statistics/";
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
		public async Task<HttpResponseMessage> GET_serveBuildRelatedIssuesOld_buildLocator_relatedissues(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/related-issues";
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
		public async Task<HttpResponseMessage> GET_serveAggregatedBuildStatusIcon_aggregated_buildLocator_statusIconsuffix(string buildLocator, string suffix)
		{
			string uriParams = string.Empty;
			string subUri = $"/aggregated/{buildLocator}/statusIcon{suffix:(.*)?}";
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
		public async Task<HttpResponseMessage> GET_serveBuildActualParameters_buildLocator_resultingproperties(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/resulting-properties";
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
		/// experimental This forces the properties reload from disk, not deletion
		/// </summary>
		public async Task<HttpResponseMessage> DELETE_resetBuildFinishParameters_buildLocator_caches_finishProperties(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/caches/finishProperties";
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
		public async Task<HttpResponseMessage> GET_serveBuildStatusIcon_buildLocator_statusIconsuffix(string buildLocator, string suffix)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/statusIcon{suffix:(.*)?}";
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
		/// Experimental only
		/// </summary>
		public async Task<HttpResponseMessage> GET_getResolvedParameter_buildLocator_resolved_value(string buildLocator, string value)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/resolved/{value}";
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
		public async Task<HttpResponseMessage> GET_serveBuildRelatedIssues_buildLocator_relatedIssues(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/relatedIssues";
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
		public async Task<HttpResponseMessage> GET_serveBuildStatisticValue_buildLocator_statistics_name(string buildLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/statistics/{name}";
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
		/// Experimental. Adds comments to multiple builds
		/// </summary>
		public async Task<HttpResponseMessage> PUT_replaceCommentMultiple_multiple_buildLocator_comment(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/multiple/{buildLocator}/comment";
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
		/// Experimental. Removes comment from multiple builds
		/// </summary>
		public async Task<HttpResponseMessage> DELETE_deleteCommentMultiple_multiple_buildLocator_comment(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/multiple/{buildLocator}/comment";
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
		public async Task<HttpResponseMessage> GET_getBuildStatusText_buildLocator_statusText(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/statusText";
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
		public async Task<HttpResponseMessage> PUT_setBuildStatusText_buildLocator_statusText(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/statusText";
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
		public async Task<HttpResponseMessage> GET_getParameters_buildLocator_attributes(string locator, string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/attributes";
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
		public async Task<HttpResponseMessage> PUT_setParameters_buildLocator_attributes(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/attributes";
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
		public async Task<HttpResponseMessage> POST_setParameter_buildLocator_attributes(string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/attributes";
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
		public async Task<HttpResponseMessage> DELETE_deleteAllParameters_buildLocator_attributes(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/attributes";
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
		public async Task<HttpResponseMessage> PUT_setParameter_buildLocator_attributes_name(string fields, string buildLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/attributes/{name}";
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
		public async Task<HttpResponseMessage> DELETE_deleteParameter_buildLocator_attributes_name(string buildLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/attributes/{name}";
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
		public async Task<HttpResponseMessage> GET_getParameter_buildLocator_attributes_name(string fields, string buildLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/attributes/{name}";
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
		/// Plain text support for pre-8.1 compatibility
		/// </summary>
		public async Task<HttpResponseMessage> PUT_setParameterValue_buildLocator_attributes_name(string buildLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/attributes/{name}";
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
		/// Plain text support for pre-8.1 compatibility
		/// </summary>
		public async Task<HttpResponseMessage> GET_getParameterValue_buildLocator_attributes_name(string buildLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/attributes/{name}";
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
		public async Task<HttpResponseMessage> GET_getParameterValueLong_buildLocator_attributes_name_value(string buildLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/attributes/{name}/value";
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
		public async Task<HttpResponseMessage> PUT_setParameterValueLong_buildLocator_attributes_name_value(string buildLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/attributes/{name}/value";
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
		public async Task<HttpResponseMessage> GET_getRoot_aggregated_buildLocator_artifacts(string basePath, string locator, string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/aggregated/{buildLocator}/artifacts";
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
		public async Task<HttpResponseMessage> GET_getContent_aggregated_buildLocator_artifacts_contentpath(string responseBuilder, string buildLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/aggregated/{buildLocator}/artifacts/content{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getChildren_aggregated_buildLocator_artifacts_childrenpath(string basePath, string locator, string fields, string buildLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/aggregated/{buildLocator}/artifacts/children{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getMetadata_aggregated_buildLocator_artifacts_metadatapath(string fields, string buildLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/aggregated/{buildLocator}/artifacts/metadata{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getChildrenAlias_aggregated_buildLocator_artifactspath(string basePath, string locator, string fields, string buildLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/aggregated/{buildLocator}/artifacts{path:(.*)?}";
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
		public async Task<HttpResponseMessage> GET_getContentAlias_aggregated_buildLocator_artifactsfilespath(string buildLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/aggregated/{buildLocator}/artifactsfiles{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getZipped_aggregated_buildLocator_artifacts_archivedpath(string basePath, string locator, string name, string buildLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/aggregated/{buildLocator}/artifacts/archived{path:(/.*)?}";
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

		/// <summary>
		/// Alias
		/// </summary>
		public async Task<HttpResponseMessage> GET_getRoot_buildLocator_artifacts(string basePath, string locator, string fields, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/artifacts";
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
		public async Task<HttpResponseMessage> GET_getContent_buildLocator_artifacts_contentpath(string responseBuilder, string buildLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/artifacts/content{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getChildren_buildLocator_artifacts_childrenpath(string basePath, string locator, string fields, string buildLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/artifacts/children{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getMetadata_buildLocator_artifacts_metadatapath(string fields, string buildLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/artifacts/metadata{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getChildrenAlias_buildLocator_artifactspath(string basePath, string locator, string fields, string buildLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/artifacts{path:(.*)?}";
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
		public async Task<HttpResponseMessage> GET_getContentAlias_buildLocator_artifactsfilespath(string buildLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/artifactsfiles{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getZipped_buildLocator_artifacts_archivedpath(string basePath, string locator, string name, string buildLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{buildLocator}/artifacts/archived{path:(/.*)?}";
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