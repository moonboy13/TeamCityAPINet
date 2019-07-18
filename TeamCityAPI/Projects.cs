using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public class ProjectsJunk
	{
		IServerConnection _serverConnection;

		//public async Task<List<ProjectSummary>> GetProjects()
	//	{
			//HttpResponseMessage response = await _serverConnection.MakeRequest("projects");

			//if (!response.IsSuccessStatusCode)
			//{
			//	throw new HttpRequestException(response.ReasonPhrase);
			//}

			//string data = await response.Content.ReadAsStringAsync();
			//JObject responseData = JObject.Parse(data);
			//List<ProjectSummary> projectSummaries = new List<ProjectSummary>();

			//foreach (JToken proj in responseData["project"].Children())
			//{
			//	ProjectSummary project = proj.ToObject<ProjectSummary>();
			//	projectSummaries.Add(project);
			//}

			//return projectSummaries;
		//}


	}
}
