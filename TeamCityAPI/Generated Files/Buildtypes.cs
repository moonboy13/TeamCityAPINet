using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public class Buildtypes
	{
		string _rootPath = "/app/rest/2018.1/buildTypes";
		IServerConnection _serverConnection;

		public Buildtypes(IServerConnection connection)
		{
			_serverConnection = connection;
		}

		/// <summary>
		/// Lists build types registered on the server. Build templates are not included by default
		/// </summary>
		public async Task<HttpResponseMessage> GET_getBuildTypes(string locator, string fields)
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
		public async Task<HttpResponseMessage> POST_addBuildType(string fields)
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
		/// Experimental support only
		/// </summary>
		public async Task<HttpResponseMessage> GET_getAliases_btLocator_aliases(string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/aliases";
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
		public async Task<HttpResponseMessage> GET_getFeature_btLocator_features_featureId(string fields, string btLocator, string featureId)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/features/{featureId}";
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
		public async Task<HttpResponseMessage> DELETE_deleteFeature_btLocator_features_featureId(string btLocator, string featureId)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/features/{featureId}";
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
		public async Task<HttpResponseMessage> PUT_replaceFeature_btLocator_features_featureId(string fields, string btLocator, string featureId)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/features/{featureId}";
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
		public async Task<HttpResponseMessage> GET_getInvestigations_btLocator_investigations(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/investigations";
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
		public async Task<HttpResponseMessage> GET_getTemplates_btLocator_templates(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/templates";
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
		public async Task<HttpResponseMessage> PUT_setTemplates_btLocator_templates(bool? optimizeSettings, string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/templates";
			if(optimizeSettings != null)
			{
				uriParams += optimizeSettings.ToString();
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
		public async Task<HttpResponseMessage> POST_addTemplate_btLocator_templates(bool? optimizeSettings, string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/templates";
			if(optimizeSettings != null)
			{
				uriParams += optimizeSettings.ToString();
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
		public async Task<HttpResponseMessage> DELETE_removeAllTemplates_btLocator_templates(bool? inlineSettings, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/templates";
			if(inlineSettings != null)
			{
				uriParams += inlineSettings.ToString();
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
		public async Task<HttpResponseMessage> DELETE_deleteBuildType_btLocator(string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}";
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
		/// Serves build configuration or templates according to the locator.
		/// </summary>
		public async Task<HttpResponseMessage> GET_serveBuildTypeXML_btLocator(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}";
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
		public async Task<HttpResponseMessage> GET_getVcsRootEntry_btLocator_vcsrootentries_vcsRootLocator(string fields, string btLocator, string vcsRootLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs-root-entries/{vcsRootLocator}";
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
		public async Task<HttpResponseMessage> PUT_updateVcsRootEntry_btLocator_vcsrootentries_vcsRootLocator(string fields, string btLocator, string vcsRootLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs-root-entries/{vcsRootLocator}";
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
		public async Task<HttpResponseMessage> DELETE_deleteVcsRootEntry_btLocator_vcsrootentries_vcsRootLocator(string btLocator, string vcsRootLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs-root-entries/{vcsRootLocator}";
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
		public async Task<HttpResponseMessage> POST_addArtifactDep_btLocator_artifactdependencies(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/artifact-dependencies";
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
		public async Task<HttpResponseMessage> GET_getArtifactDeps_btLocator_artifactdependencies(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/artifact-dependencies";
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
		/// Replaces the dependencies to those sent in the request.
		/// </summary>
		public async Task<HttpResponseMessage> PUT_replaceArtifactDeps_btLocator_artifactdependencies(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/artifact-dependencies";
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
		public async Task<HttpResponseMessage> GET_getStepParameter_btLocator_steps_stepId_parameters_parameterName(string btLocator, string stepId, string parameterName)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/steps/{stepId}/parameters/{parameterName}";
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
		public async Task<HttpResponseMessage> PUT_addStepParameter_btLocator_steps_stepId_parameters_parameterName(string btLocator, string stepId, string parameterName)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/steps/{stepId}/parameters/{parameterName}";
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
		public async Task<HttpResponseMessage> PUT_replaceStep_btLocator_steps_stepId(string fields, string btLocator, string stepId)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/steps/{stepId}";
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
		public async Task<HttpResponseMessage> DELETE_deleteStep_btLocator_steps_stepId(string btLocator, string stepId)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/steps/{stepId}";
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
		public async Task<HttpResponseMessage> GET_getStep_btLocator_steps_stepId(string fields, string btLocator, string stepId)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/steps/{stepId}";
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
		public async Task<HttpResponseMessage> PUT_replaceFeatures_btLocator_features(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/features";
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
		public async Task<HttpResponseMessage> GET_getFeatures_btLocator_features(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/features";
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
		public async Task<HttpResponseMessage> POST_addFeature_btLocator_features(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/features";
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
		public async Task<HttpResponseMessage> GET_getSnapshotDeps_btLocator_snapshotdependencies(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/snapshot-dependencies";
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
		/// Creates new snapshot dependency. 'id' attribute is ignored in the submitted descriptor. Reports error if new dependency cannot be created (e.g. another dependency on the specified build configuration already exists).
		/// </summary>
		public async Task<HttpResponseMessage> POST_addSnapshotDep_btLocator_snapshotdependencies(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/snapshot-dependencies";
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
		/// Replaces snapshot dependency with those sent in request.
		/// </summary>
		public async Task<HttpResponseMessage> PUT_replaceSnapshotDeps_btLocator_snapshotdependencies(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/snapshot-dependencies";
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
		/// Replaces trigger with those sent inthe request.
		/// </summary>
		public async Task<HttpResponseMessage> PUT_replaceTriggers_btLocator_triggers(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/triggers";
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
		/// Creates new trigger. 'id' attribute is ignored in the submitted descriptor. Reports error if new trigger cannot be created (e.g. only single trigger of the type is allowed for a build configuration).
		/// </summary>
		public async Task<HttpResponseMessage> POST_addTrigger_btLocator_triggers(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/triggers";
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
		public async Task<HttpResponseMessage> GET_getTriggers_btLocator_triggers(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/triggers";
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
		public async Task<HttpResponseMessage> PUT_replaceSteps_btLocator_steps(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/steps";
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
		public async Task<HttpResponseMessage> GET_getSteps_btLocator_steps(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/steps";
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
		public async Task<HttpResponseMessage> POST_addStep_btLocator_steps(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/steps";
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
		public async Task<HttpResponseMessage> GET_getStepSetting_btLocator_steps_stepId_fieldName(string btLocator, string stepId, string fieldName)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/steps/{stepId}/{fieldName}";
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
		public async Task<HttpResponseMessage> PUT_changeStepSetting_btLocator_steps_stepId_fieldName(string btLocator, string stepId, string fieldName)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/steps/{stepId}/{fieldName}";
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
		public async Task<HttpResponseMessage> DELETE_deleteTrigger_btLocator_triggers_triggerLocator(string btLocator, string triggerLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/triggers/{triggerLocator}";
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
		public async Task<HttpResponseMessage> PUT_replaceTrigger_btLocator_triggers_triggerLocator(string fields, string btLocator, string triggerLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/triggers/{triggerLocator}";
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
		public async Task<HttpResponseMessage> GET_getTrigger_btLocator_triggers_triggerLocator(string fields, string btLocator, string triggerLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/triggers/{triggerLocator}";
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
		public async Task<HttpResponseMessage> GET_serveBuildField_btLocator_builds_buildLocator_field(string btLocator, string buildLocator, string field)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/builds/{buildLocator}/{field}";
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
		/// Serves builds matching supplied condition.
		/// </summary>
		public async Task<HttpResponseMessage> GET_serveBuilds_btLocator_builds(string status, string triggeredByUser, bool? includePersonal, bool? includeCanceled, bool? onlyPinned, string tag, string agentName, string sinceBuild, string sinceDate, long? start, int? count, string locator, string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/builds";
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
		/// Lists branches of the build type.
		/// </summary>
		public async Task<HttpResponseMessage> GET_serveBranches_btLocator_branches(string locator, string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/branches";
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
		public async Task<HttpResponseMessage> DELETE_removeTemplate_btLocator_templates_templateLocator(bool? inlineSettings, string btLocator, string templateLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/templates/{templateLocator}";
			if(inlineSettings != null)
			{
				uriParams += inlineSettings.ToString();
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
		public async Task<HttpResponseMessage> GET_getTemplate_btLocator_templates_templateLocator(string fields, string btLocator, string templateLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/templates/{templateLocator}";
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
		public async Task<HttpResponseMessage> GET_getSettingsFile_btLocator_settingsFile(string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/settingsFile";
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
		public async Task<HttpResponseMessage> POST_addVcsRootEntry_btLocator_vcsrootentries(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs-root-entries";
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
		public async Task<HttpResponseMessage> GET_getVcsRootEntries_btLocator_vcsrootentries(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs-root-entries";
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
		public async Task<HttpResponseMessage> PUT_replaceVcsRootEntries_btLocator_vcsrootentries(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs-root-entries";
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
		public async Task<HttpResponseMessage> GET_getAgentRequirements_btLocator_agentrequirements(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/agent-requirements";
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
		/// Replaces agent requirements with those sent in the request.
		/// </summary>
		public async Task<HttpResponseMessage> PUT_replaceAgentRequirements_btLocator_agentrequirements(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/agent-requirements";
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
		/// Creates new agent requirement. 'id' attribute is ignored in the submitted descriptor. Reports error if new requirement cannot be created (e.g. another requirement is present for the parameter).
		/// </summary>
		public async Task<HttpResponseMessage> POST_addAgentRequirement_btLocator_agentrequirements(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/agent-requirements";
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
		/// Experimental support only. Use this to get an example of the bean to be posted to the /buildTypes request to create a new build type
		/// </summary>
		public async Task<HttpResponseMessage> GET_getExampleNewProjectDescription_btLocator_example_newBuildTypeDescription(string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/example/newBuildTypeDescription";
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
		public async Task<HttpResponseMessage> GET_getVcsRootEntryCheckoutRules_btLocator_vcsrootentries_vcsRootLocator_checkoutrules(string btLocator, string vcsRootLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs-root-entries/{vcsRootLocator}/checkout-rules";
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
		public async Task<HttpResponseMessage> PUT_updateVcsRootEntryCheckoutRules_btLocator_vcsrootentries_vcsRootLocator_checkoutrules(string btLocator, string vcsRootLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs-root-entries/{vcsRootLocator}/checkout-rules";
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
		public async Task<HttpResponseMessage> DELETE_deleteTemplateAssociation_btLocator_template(bool? inlineSettings, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/template";
			if(inlineSettings != null)
			{
				uriParams += inlineSettings.ToString();
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
		public async Task<HttpResponseMessage> GET_serveBuildTypeTemplate_btLocator_template(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/template";
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
		public async Task<HttpResponseMessage> PUT_getTemplateAssociation_btLocator_template(string fields, bool? inlineSettings, bool? optimizeSettings, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/template";
			if(fields != string.Empty)
			{
				uriParams += fields;
			}
			if(inlineSettings != null)
			{
				uriParams += inlineSettings.ToString();
			}
			if(optimizeSettings != null)
			{
				uriParams += optimizeSettings.ToString();
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
		/// For compatibility with experimental feature of 8.0
		/// </summary>
		public async Task<HttpResponseMessage> GET_getExampleNewProjectDescriptionCompatibilityVersion1_btLocator_newBuildTypeDescription(string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/newBuildTypeDescription";
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
		public async Task<HttpResponseMessage> GET_serveBuildTypeField_btLocator_field(string btLocator, string field)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/{field}";
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
		public async Task<HttpResponseMessage> PUT_setBuildTypeField_btLocator_field(string btLocator, string field)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/{field}";
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
		public async Task<HttpResponseMessage> GET_serveBuildTypeBuildsTags_btLocator_buildTags(string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/buildTags";
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
		public async Task<HttpResponseMessage> DELETE_deleteArtifactDep_btLocator_artifactdependencies_artifactDepLocator(string btLocator, string artifactDepLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/artifact-dependencies/{artifactDepLocator}";
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
		public async Task<HttpResponseMessage> PUT_replaceArtifactDep_btLocator_artifactdependencies_artifactDepLocator(string fields, string btLocator, string artifactDepLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/artifact-dependencies/{artifactDepLocator}";
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
		public async Task<HttpResponseMessage> GET_getArtifactDep_btLocator_artifactdependencies_artifactDepLocator(string fields, string btLocator, string artifactDepLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/artifact-dependencies/{artifactDepLocator}";
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
		public async Task<HttpResponseMessage> GET_getFeatureParameter_btLocator_features_featureId_parameters_parameterName(string btLocator, string featureId, string parameterName)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/features/{featureId}/parameters/{parameterName}";
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
		public async Task<HttpResponseMessage> PUT_addFeatureParameter_btLocator_features_featureId_parameters_parameterName(string btLocator, string featureId, string parameterName)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/features/{featureId}/parameters/{parameterName}";
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
		public async Task<HttpResponseMessage> GET_getTriggerSetting_btLocator_triggers_triggerLocator_fieldName(string btLocator, string triggerLocator, string fieldName)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/triggers/{triggerLocator}/{fieldName}";
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
		public async Task<HttpResponseMessage> PUT_changeTriggerSetting_btLocator_triggers_triggerLocator_fieldName(string btLocator, string triggerLocator, string fieldName)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/triggers/{triggerLocator}/{fieldName}";
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
		public async Task<HttpResponseMessage> GET_getStepParameters_btLocator_steps_stepId_parameters(string fields, string btLocator, string stepId)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/steps/{stepId}/parameters";
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
		public async Task<HttpResponseMessage> PUT_replaceStepParameters_btLocator_steps_stepId_parameters(string fields, string btLocator, string stepId)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/steps/{stepId}/parameters";
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
		public async Task<HttpResponseMessage> GET_getArtifactDepSetting_btLocator_artifactdependencies_artifactDepLocator_fieldName(string btLocator, string artifactDepLocator, string fieldName)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/artifact-dependencies/{artifactDepLocator}/{fieldName}";
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
		public async Task<HttpResponseMessage> PUT_changeArtifactDepSetting_btLocator_artifactdependencies_artifactDepLocator_fieldName(string btLocator, string artifactDepLocator, string fieldName)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/artifact-dependencies/{artifactDepLocator}/{fieldName}";
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
		public async Task<HttpResponseMessage> PUT_replaceAgentRequirement_btLocator_agentrequirements_agentRequirementLocator(string fields, string btLocator, string agentRequirementLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/agent-requirements/{agentRequirementLocator}";
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
		public async Task<HttpResponseMessage> DELETE_deleteAgentRequirement_btLocator_agentrequirements_agentRequirementLocator(string btLocator, string agentRequirementLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/agent-requirements/{agentRequirementLocator}";
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
		public async Task<HttpResponseMessage> GET_getAgentRequirement_btLocator_agentrequirements_agentRequirementLocator(string fields, string btLocator, string agentRequirementLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/agent-requirements/{agentRequirementLocator}";
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
		public async Task<HttpResponseMessage> DELETE_deleteSnapshotDep_btLocator_snapshotdependencies_snapshotDepLocator(string btLocator, string snapshotDepLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/snapshot-dependencies/{snapshotDepLocator}";
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
		public async Task<HttpResponseMessage> PUT_replaceSnapshotDep_btLocator_snapshotdependencies_snapshotDepLocator(string fields, string btLocator, string snapshotDepLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/snapshot-dependencies/{snapshotDepLocator}";
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
		public async Task<HttpResponseMessage> GET_getSnapshotDep_btLocator_snapshotdependencies_snapshotDepLocator(string fields, string btLocator, string snapshotDepLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/snapshot-dependencies/{snapshotDepLocator}";
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
		public async Task<HttpResponseMessage> GET_getRequirementSetting_btLocator_agentrequirements_agentRequirementLocator_fieldName(string btLocator, string agentRequirementLocator, string fieldName)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/agent-requirements/{agentRequirementLocator}/{fieldName}";
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
		public async Task<HttpResponseMessage> PUT_changeRequirementSetting_btLocator_agentrequirements_agentRequirementLocator_fieldName(string btLocator, string agentRequirementLocator, string fieldName)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/agent-requirements/{agentRequirementLocator}/{fieldName}";
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
		public async Task<HttpResponseMessage> PUT_changeFeatureSetting_btLocator_features_featureId_name(string btLocator, string featureId, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/features/{featureId}/{name}";
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
		public async Task<HttpResponseMessage> GET_getFeatureSetting_btLocator_features_featureId_name(string btLocator, string featureId, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/features/{featureId}/{name}";
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
		/// Experimental support only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getCurrentVcsInstances_btLocator_vcsRootInstances(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcsRootInstances";
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
		public async Task<HttpResponseMessage> GET_getFeatureParameters_btLocator_features_featureId_parameters(string fields, string btLocator, string featureId)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/features/{featureId}/parameters";
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
		public async Task<HttpResponseMessage> PUT_replaceFeatureParameters_btLocator_features_featureId_parameters(string fields, string btLocator, string featureId)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/features/{featureId}/parameters";
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
		/// Sets VCS labeling settings Experimental support only
		/// </summary>
		public async Task<HttpResponseMessage> PUT_setVCSLabelingOptions_btLocator_vcsLabeling(string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcsLabeling";
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
		/// Gets VCS labeling settings Experimental support only
		/// </summary>
		public async Task<HttpResponseMessage> GET_getVCSLabelingOptions_btLocator_vcsLabeling(string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcsLabeling";
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
		public async Task<HttpResponseMessage> GET_serveBuildWithProject_btLocator_builds_buildLocator(string fields, string btLocator, string buildLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/builds/{buildLocator}";
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
		/// Experimental support only!
		/// </summary>
		public async Task<HttpResponseMessage> GET_getCurrentVcsInstancesObsolete_btLocator_vcsrootinstances(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs-root-instances";
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
		public async Task<HttpResponseMessage> GET_getParameters_btLocator_settings(string locator, string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/settings";
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
		public async Task<HttpResponseMessage> PUT_setParameters_btLocator_settings(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/settings";
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
		public async Task<HttpResponseMessage> POST_setParameter_btLocator_settings(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/settings";
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
		public async Task<HttpResponseMessage> DELETE_deleteAllParameters_btLocator_settings(string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/settings";
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
		public async Task<HttpResponseMessage> PUT_setParameter_btLocator_settings_name(string fields, string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/settings/{name}";
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
		public async Task<HttpResponseMessage> DELETE_deleteParameter_btLocator_settings_name(string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/settings/{name}";
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
		public async Task<HttpResponseMessage> GET_getParameter_btLocator_settings_name(string fields, string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/settings/{name}";
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
		public async Task<HttpResponseMessage> PUT_setParameterValue_btLocator_settings_name(string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/settings/{name}";
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
		public async Task<HttpResponseMessage> GET_getParameterValue_btLocator_settings_name(string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/settings/{name}";
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
		public async Task<HttpResponseMessage> GET_getParameterValueLong_btLocator_settings_name_value(string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/settings/{name}/value";
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
		public async Task<HttpResponseMessage> PUT_setParameterValueLong_btLocator_settings_name_value(string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/settings/{name}/value";
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
		public async Task<HttpResponseMessage> GET_getParameters_btLocator_parameters(string locator, string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters";
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
		public async Task<HttpResponseMessage> PUT_setParameters_btLocator_parameters(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters";
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
		public async Task<HttpResponseMessage> POST_setParameter_btLocator_parameters(string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters";
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
		public async Task<HttpResponseMessage> DELETE_deleteAllParameters_btLocator_parameters(string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters";
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
		public async Task<HttpResponseMessage> GET_getParameterType_btLocator_parameters_name_type(string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters/{name}/type";
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
		public async Task<HttpResponseMessage> PUT_setParameterType_btLocator_parameters_name_type(string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters/{name}/type";
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
		public async Task<HttpResponseMessage> PUT_setParameterTypeRawValue_btLocator_parameters_name_type_rawValue(string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters/{name}/type/rawValue";
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
		public async Task<HttpResponseMessage> GET_getParameterTypeRawValue_btLocator_parameters_name_type_rawValue(string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters/{name}/type/rawValue";
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
		public async Task<HttpResponseMessage> PUT_setParameter_btLocator_parameters_name(string fields, string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters/{name}";
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
		public async Task<HttpResponseMessage> DELETE_deleteParameter_btLocator_parameters_name(string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters/{name}";
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
		public async Task<HttpResponseMessage> GET_getParameter_btLocator_parameters_name(string fields, string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters/{name}";
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
		public async Task<HttpResponseMessage> PUT_setParameterValue_btLocator_parameters_name(string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters/{name}";
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
		public async Task<HttpResponseMessage> GET_getParameterValue_btLocator_parameters_name(string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters/{name}";
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
		public async Task<HttpResponseMessage> GET_getParameterValueLong_btLocator_parameters_name_value(string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters/{name}/value";
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
		public async Task<HttpResponseMessage> PUT_setParameterValueLong_btLocator_parameters_name_value(string btLocator, string name)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/parameters/{name}/value";
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
		public async Task<HttpResponseMessage> GET_getRoot_btLocator_vcs_files_latest(string basePath, string locator, string fields, string btLocator)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs/files/latest";
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
		public async Task<HttpResponseMessage> GET_getContent_btLocator_vcs_files_latest_contentpath(string responseBuilder, string btLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs/files/latest/content{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getChildren_btLocator_vcs_files_latest_childrenpath(string basePath, string locator, string fields, string btLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs/files/latest/children{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getMetadata_btLocator_vcs_files_latest_metadatapath(string fields, string btLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs/files/latest/metadata{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getChildrenAlias_btLocator_vcs_files_latestpath(string basePath, string locator, string fields, string btLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs/files/latest{path:(.*)?}";
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
		public async Task<HttpResponseMessage> GET_getContentAlias_btLocator_vcs_files_latestfilespath(string btLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs/files/latestfiles{path:(/.*)?}";
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
		public async Task<HttpResponseMessage> GET_getZipped_btLocator_vcs_files_latest_archivedpath(string basePath, string locator, string name, string btLocator, string path)
		{
			string uriParams = string.Empty;
			string subUri = $"/{btLocator}/vcs/files/latest/archived{path:(/.*)?}";
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