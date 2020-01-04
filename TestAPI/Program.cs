using System;
using TeamCityAPI;

namespace TestAPI
{
	class Program
	{
		static void Main(string[] args)
		{
			var conn = new ServerConnection("192.168.56.1", 8080);
			var foo = conn.TestConnection().Result;
		}
	}
}
