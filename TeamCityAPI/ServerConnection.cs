using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TeamCityAPI
{
	/// <summary>
	/// Supported connection types to a TeamCity instance
	/// </summary>
	public enum ConnectionType
	{
		Guest,
		Token,
		Basic
		
	}



	/// <summary>
	/// Responsible for creating the connection to the TeamCity server instance.
	/// Consider using the factory design pattern here (no public constructors).
	/// </summary>
	public class ServerConnection : IServerConnection
	{
		string _serverURL;
		string _username;
		string _password;
		string _token;
		string _authorization;
		ConnectionType _connectionType;
		private static HttpClient _client = new HttpClient();
		TimeSpan _defaultTimeout = new TimeSpan(0, 0, 30); // Default request timeout of 30 seconds

		/// <summary>
		/// Initialize a new instance of the TeamCity server connection class.
		/// </summary>
		/// <param name="serverURL"></param>
		/// <param name="username"></param>
		/// <param name="password"></param>
		public ServerConnection(string baseURL, int port, string username, string password)
			: this()
		{
			_connectionType = ConnectionType.Basic;
			_authorization = "Basic";
			_username = username;
			_password = password;
			_serverURL = string.Format("http://{0}:{1}/{2}", baseURL, port.ToString(), "httpAuth");
		}

		public ServerConnection(string baseURL, int port, string token)
			: this()
		{
			_connectionType = ConnectionType.Token;
			_authorization = "Bearer";
			_token = token;
			_serverURL = string.Format("http://{0}:{1}", baseURL, port.ToString());
		}

		public ServerConnection(string baseURL, int port)
			: this()
		{
			_connectionType = ConnectionType.Guest;
			_serverURL = string.Format("http://{0}:{1}/{2}", baseURL, port.ToString(), "guestAuth");
		}

		/// <summary>
		/// Primarily a testing method. This allows you to override the default HttpMessageHandler
		/// </summary>
		/// <param name="newHandler"></param>
		public void ConfigureMessageHandler(HttpMessageHandler newHandler)
		{
			// Release and dispose the old connection before opening up a new one.
			_client.CancelPendingRequests();
			_client.Dispose();
			_client = new HttpClient(newHandler);
		}

		private ServerConnection()
		{
			BuildDefaultRequestHeaders();
			_client.Timeout = _defaultTimeout;
		}

		private void BuildDefaultRequestHeaders()
		{
			_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}

		/// <summary>
		/// Dispose uneeded resources.
		/// </summary>
		public void Dispose()
		{
			_client.CancelPendingRequests();
			_client.Dispose();
			_client = new HttpClient();
		}

		/// <summary>
		/// Set a new timeout for the client. Use this carefully as it will cancel any pending request.
		/// </summary>
		/// <param name="newTimeout"></param>
		public void SetTimeout(TimeSpan newTimeout) 
		{
			Dispose();
			_client = new HttpClient();
			BuildDefaultRequestHeaders();
			_client.Timeout = newTimeout;
		}

		/// <summary> 
		/// Validate we can connect succesfully to the server.
		/// </summary>
		public async Task<bool> TestConnection()
		{
			_client.DefaultRequestHeaders.Authorization = BuildAuthHeader();
			HttpResponseMessage response = await _client
				.GetAsync(string.Format("{0}/app/rest/server", _serverURL))
				.ConfigureAwait(false);
			return response.IsSuccessStatusCode;
		}

		private AuthenticationHeaderValue BuildAuthHeader()
		{
			switch (_connectionType)
			{
				case ConnectionType.Basic:
					return new AuthenticationHeaderValue(_authorization,
						Convert.ToBase64String(Encoding.ASCII.GetBytes(String.Format("{0}:{1}", _username, _password))));
				case ConnectionType.Guest:
					return null;
				case ConnectionType.Token:
				default:
					return new AuthenticationHeaderValue(_authorization, _token);
			}
		}

		/// <summary>
		/// Makes a request of the API.
		/// </summary>
		/// <param name="requestURI">URI to request against.</param>
		/// <param name="callback">Handler function for the response.</param>
		public async Task<HttpResponseMessage> MakeRequest(string requestURI)
		{
			_client.DefaultRequestHeaders.Authorization = BuildAuthHeader();
			HttpResponseMessage response = await _client
				.GetAsync(string.Format("{0}{1}", _serverURL, requestURI))
				.ConfigureAwait(false);
			// TODO: There is some basic handling on a failed request that should be tried, like re-authenticating.

			return response;

		}

	}
}
