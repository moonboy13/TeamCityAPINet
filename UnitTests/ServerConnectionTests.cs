using NUnit.Framework;
using TeamCityAPI;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using System.Net.Http;
using Moq.Protected;
using System.Threading;
using System.Net;
using System.Threading.Tasks;

namespace TeamCityAPI.Tests
{
	[TestFixture()]
	public class ServerConnectionTests
	{
		StringContent goodResponse = new StringContent("This is a root of TeamCity REST API.\r\nExplore what's inside from '/app/rest/server'."+
			"\r\nGet WADL with the full list of supported requests via '/app/rest/application.wadl'.\r\nSee also notes on the usage at https://www.jetbrains.com/help/teamcity/2019.1/?REST+API");
		
		ServerConnection _connection;

		[Test()]
		[Description("Basic test that verifies how the API should handle when it is initialized with a valid guest connection.")]
		public async Task GuestAuthServerConnectionTest_SuccessfulRequest()
		{
			// Arrange
			var handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Loose);
			handlerMock
				.Protected()
				// Setup the PROTECTED method to mock
				.Setup<Task<HttpResponseMessage>>(
					"SendAsync",
					ItExpr.IsAny<HttpRequestMessage>(),
					ItExpr.IsAny<CancellationToken>()
				)
				// prepare the expected response of the mocked http call
				.ReturnsAsync(new HttpResponseMessage()
				{
					StatusCode = HttpStatusCode.OK,
					Content = goodResponse,
				})
				.Verifiable();

			_connection = new ServerConnection("127.0.0.1", 80);
			_connection.ConfigureMessageHandler(handlerMock.Object);
			var expectedUri = new Uri("http://127.0.0.1:80/guestAuth/app/rest/");

			// Act
			var request = _connection.TestConnection();

			// Verify
			Assert.IsNotNull(request);
			Assert.That(request, Is.InstanceOf(typeof(Task<bool>)));

			bool response = await request;
			Assert.That(response);

			handlerMock.Protected().Verify("SendAsync",
				Times.Once(),
				ItExpr.Is<HttpRequestMessage>(req =>
					req.Method == HttpMethod.Get && req.RequestUri == expectedUri),
				ItExpr.IsAny<CancellationToken>());
		}

		[Test()]
		[Description("Test what happens on a guest connection when we are able to reach the server but an invalid URI is used.")]
		public async Task GuestAuthServerConnectionTest_404Response()
		{
			// Arrange
			var handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Loose);
			StringContent badResponse = new StringContent("Not Found");
			handlerMock
				.Protected()
				// Setup the PROTECTED method to mock
				.Setup<Task<HttpResponseMessage>>(
					"SendAsync",
					ItExpr.IsAny<HttpRequestMessage>(),
					ItExpr.IsAny<CancellationToken>()
				)
				// prepare the expected response of the mocked http call
				.ReturnsAsync(new HttpResponseMessage()
				{
					StatusCode = HttpStatusCode.NotFound,
					Content = badResponse,
				})
				.Verifiable();

			_connection = new ServerConnection("127.0.0.1", 80);
			_connection.ConfigureMessageHandler(handlerMock.Object);
			var expectedUri = new Uri("http://127.0.0.1:80/guestAuth/app/rest/foo/bar");

			// Act
			var request = _connection.MakeRequest("foo/bar");

			// Verify
			Assert.IsNotNull(request);
			Assert.That(request, Is.InstanceOf(typeof(Task<HttpResponseMessage>)));

			HttpResponseMessage response = await request;
			Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
			Assert.That(response.ReasonPhrase, Is.EqualTo(await badResponse.ReadAsStringAsync()));

			handlerMock.Protected().Verify("SendAsync",
				Times.Once(),
				ItExpr.Is<HttpRequestMessage>(req =>
					req.Method == HttpMethod.Get && req.RequestUri == expectedUri),
				ItExpr.IsAny<CancellationToken>());
		}

		[Test()]
		public async Task BasicAuthServerConnectionTest_SuccessfulRequest()
		{
			// Arrange
			var handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Loose);
			handlerMock
				.Protected()
				// Setup the PROTECTED method to mock
				.Setup<Task<HttpResponseMessage>>(
					"SendAsync",
					ItExpr.IsAny<HttpRequestMessage>(),
					ItExpr.IsAny<CancellationToken>()
				)
				// prepare the expected response of the mocked http call
				.ReturnsAsync(new HttpResponseMessage()
				{
					StatusCode = HttpStatusCode.OK,
					Content = goodResponse,
				})
				.Verifiable();
			string user = "Foo";
			string password = "Bar";


			_connection = new ServerConnection("127.0.0.1", 80, user, password);
			_connection.ConfigureMessageHandler(handlerMock.Object);
			var expectedUri = new Uri("http://127.0.0.1:80/httpAuth/app/rest/");

			// Act
			var request = _connection.TestConnection();

			// Verify
			Assert.IsNotNull(request);
			Assert.That(request, Is.InstanceOf(typeof(Task<bool>)));

			bool response = await request;
			Assert.That(response);

			handlerMock.Protected().Verify("SendAsync",
				Times.Once(),
				ItExpr.Is<HttpRequestMessage>(req =>
					req.Method == HttpMethod.Get && req.RequestUri == expectedUri 
					&& req.Headers.Authorization.Scheme == "Basic"
					&& req.Headers.Authorization.Parameter == Convert.ToBase64String(Encoding.ASCII.GetBytes(String.Format("{0}:{1}", user, password)))),
				ItExpr.IsAny<CancellationToken>());
		}

		[Test()]
		public async Task TokenAuthServerConnectionTest_SuccessfulRequest()
		{
			// Arrange
			var handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Loose);
			handlerMock
				.Protected()
				// Setup the PROTECTED method to mock
				.Setup<Task<HttpResponseMessage>>(
					"SendAsync",
					ItExpr.IsAny<HttpRequestMessage>(),
					ItExpr.IsAny<CancellationToken>()
				)
				// prepare the expected response of the mocked http call
				.ReturnsAsync(new HttpResponseMessage()
				{
					StatusCode = HttpStatusCode.OK,
					Content = goodResponse,
				})
				.Verifiable();
			string token = "TestingToken";


			_connection = new ServerConnection("127.0.0.1", 80, token);
			_connection.ConfigureMessageHandler(handlerMock.Object);
			var expectedUri = new Uri("http://127.0.0.1:80/app/rest/");

			// Act
			var request = _connection.TestConnection();

			// Verify
			Assert.IsNotNull(request);
			Assert.That(request, Is.InstanceOf(typeof(Task<bool>)));

			bool response = await request;
			Assert.That(response);

			handlerMock.Protected().Verify("SendAsync",
				Times.Once(),
				ItExpr.Is<HttpRequestMessage>(req =>
					req.Method == HttpMethod.Get && req.RequestUri == expectedUri
					&& req.Headers.Authorization.Scheme == "Bearer"
					&& req.Headers.Authorization.Parameter == token),
				ItExpr.IsAny<CancellationToken>());
		}

		[TearDown]
		public void TearDown()
		{
			_connection?.Dispose();
		}
	}
}