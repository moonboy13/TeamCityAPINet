using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public class DebugConnector
	{
		string _rootPath = "/app/rest/2018.1/debug";
		IServerConnection _serverConnection;

		public DebugConnector(IServerConnection connection)
		{
			_serverConnection = connection;
		}

		/// <summary>
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getDate_date_dateLocator(string format, string timezone, string dateLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/date/{dateLocator}";
			if(format != string.Empty)
			{
				uriParams += format;
			}
			if(timezone != string.Empty)
			{
				uriParams += timezone;
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getSystemProperties_jvm_systemProperties(string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/jvm/systemProperties";
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getSessions_sessions(long? manager, string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/sessions";
			if(manager != null)
			{
				uriParams += manager.ToString();
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
		public async Task<HttpResponseMessage> DELETE_invalidateCurrentSession_currentRequest_session()
		{
			string uriParams = string.Empty;
			string subUri = $"/currentRequest/session";
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
		public async Task<HttpResponseMessage> GET_getCurrentSession_currentRequest_session(string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/currentRequest/session";
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
		public async Task<HttpResponseMessage> DELETE_deleteCurrentRememberMe_currentRequest_rememberMe()
		{
			string uriParams = string.Empty;
			string subUri = $"/currentRequest/rememberMe";
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
		public async Task<HttpResponseMessage> POST_newRememberMe_currentRequest_rememberMe()
		{
			string uriParams = string.Empty;
			string subUri = $"/currentRequest/rememberMe";
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
		public async Task<HttpResponseMessage> GET_getCachedBuildsStat_caches_builds_stats(string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/caches/builds/stats";
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getThreadInterrupted_threads_threadLocator_interrupted(string threadLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/threads/{threadLocator}/interrupted";
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> PUT_interruptThread_threads_threadLocator_interrupted(string threadLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/threads/{threadLocator}/interrupted";
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
		/// experimental use only. Allow to get raw investigations without filtering by no longer present projects, etc.
		/// </summary>
		public async Task<HttpResponseMessage> GET_getRawInvestigations_investigations(string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/investigations";
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
		public async Task<HttpResponseMessage> PUT_putRequestDetails_currentRequest_detailsextra(string extra)
		{
			string uriParams = string.Empty;
			string subUri = $"/currentRequest/details{extra:(/.*)?}";
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
		public async Task<HttpResponseMessage> POST_postRequestDetails_currentRequest_detailsextra(string extra)
		{
			string uriParams = string.Empty;
			string subUri = $"/currentRequest/details{extra:(/.*)?}";
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getRequestDetails_currentRequest_detailsextra(string extra)
		{
			string uriParams = string.Empty;
			string subUri = $"/currentRequest/details{extra:(/.*)?}";
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
		/// experimental use only.
		/// </summary>
		public async Task<HttpResponseMessage> GET_getDiagnosticsPerfStats_diagnostics_threadPerfStat_stats(string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/diagnostics/threadPerfStat/stats";
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
		public async Task<HttpResponseMessage> GET_getCachedBuildPromotions_caches_buildPromotions_content(string buildTypeLocator, string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/caches/buildPromotions/content";
			if(buildTypeLocator != string.Empty)
			{
				uriParams += buildTypeLocator;
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getThreadDump_threadDump(string lockedMonitors, string lockedSynchronizers, string detectLocks)
		{
			string uriParams = string.Empty;
			string subUri = $"/threadDump";
			if(lockedMonitors != string.Empty)
			{
				uriParams += lockedMonitors;
			}
			if(lockedSynchronizers != string.Empty)
			{
				uriParams += lockedSynchronizers;
			}
			if(detectLocks != string.Empty)
			{
				uriParams += detectLocks;
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
		public async Task<HttpResponseMessage> GET_getIpAddress_dns_lookup_host(string host)
		{
			string uriParams = string.Empty;
			string subUri = $"/dns/lookup/{host}";
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
		/// experimental use only.
		/// </summary>
		public async Task<HttpResponseMessage> POST_requestGc_jvm_gc()
		{
			string uriParams = string.Empty;
			string subUri = $"/jvm/gc";
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> POST_scheduleCheckingForChanges_vcsCheckingForChangesQueue(string locator, string requestor, string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/vcsCheckingForChangesQueue";
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getCurrentUserPermissions_currentUserPermissions()
		{
			string uriParams = string.Empty;
			string subUri = $"/currentUserPermissions";
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
		/// Experimental use only! Related to https://youtrack.jetbrains.com/issue/TW-37419
		/// </summary>
		public async Task<HttpResponseMessage> GET_getBuildChainOptimizationLog_buildChainOptimizationLog_buildLocator(string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/buildChainOptimizationLog/{buildLocator}";
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
		public async Task<HttpResponseMessage> GET_getCachedBuildPromotionsStats_caches_buildPromotions_stats(string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/caches/buildPromotions/stats";
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getEnvironmentVariables_jvm_environmentVariables(string fields)
		{
			string uriParams = string.Empty;
			string subUri = $"/jvm/environmentVariables";
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> POST_emptyTask_emptyTask(string time, int? load, int? memory, int? memoryChunks)
		{
			string uriParams = string.Empty;
			string subUri = $"/emptyTask";
			if(time != string.Empty)
			{
				uriParams += time;
			}
			if(load != null)
			{
				uriParams += load.ToString();
			}
			if(memory != null)
			{
				uriParams += memory.ToString();
			}
			if(memoryChunks != null)
			{
				uriParams += memoryChunks.ToString();
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> POST_saveMemoryDump_memory_dumps(bool? archived)
		{
			string uriParams = string.Empty;
			string subUri = $"/memory/dumps";
			if(archived != null)
			{
				uriParams += archived.ToString();
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
		public async Task<HttpResponseMessage> GET_listDBTables_database_tables()
		{
			string uriParams = string.Empty;
			string subUri = $"/database/tables";
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
		public async Task<HttpResponseMessage> GET_executeDBQuery_database_query_query(string fieldDelimiter, string dataRetrieveQuery, int? count, string query)
		{
			string uriParams = string.Empty;
			string subUri = $"/database/query/{query}";
			if(fieldDelimiter != string.Empty)
			{
				uriParams += fieldDelimiter;
			}
			if(dataRetrieveQuery != string.Empty)
			{
				uriParams += dataRetrieveQuery;
			}
			if(count != null)
			{
				uriParams += count.ToString();
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getScrambled_values_password_scrambled(string value)
		{
			string uriParams = string.Empty;
			string subUri = $"/values/password/scrambled";
			if(value != string.Empty)
			{
				uriParams += value;
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getHashed_values_transform_method(string value, string method)
		{
			string uriParams = string.Empty;
			string subUri = $"/values/transform/{method}";
			if(value != string.Empty)
			{
				uriParams += value;
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
		/// Experimental use only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getUnscrambled_values_password_unscrambled(string value)
		{
			string uriParams = string.Empty;
			string subUri = $"/values/password/unscrambled";
			if(value != string.Empty)
			{
				uriParams += value;
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
		/// experimental use only.
		/// </summary>
		public async Task<HttpResponseMessage> POST_requestFinalization_jvm_finalization()
		{
			string uriParams = string.Empty;
			string subUri = $"/jvm/finalization";
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
		public async Task<HttpResponseMessage> PUT_setCurrentSessionMaxInactiveInterval_currentRequest_session_maxInactiveSeconds()
		{
			string uriParams = string.Empty;
			string subUri = $"/currentRequest/session/maxInactiveSeconds";
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
		public async Task<HttpResponseMessage> GET_getCurrentSessionMaxInactiveInterval_currentRequest_session_maxInactiveSeconds()
		{
			string uriParams = string.Empty;
			string subUri = $"/currentRequest/session/maxInactiveSeconds";
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