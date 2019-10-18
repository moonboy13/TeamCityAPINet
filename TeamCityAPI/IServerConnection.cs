using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	public interface IServerConnection : IDisposable
	{
		Task<HttpResponseMessage> MakeRequest(string requestURI);
		Task<bool> TestConnection();
	}
 }