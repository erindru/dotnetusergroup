using System;
using System.Net.Http;
using app;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace app_test {
      public class ControllerTestFixture : IDisposable {
        public HttpClient Client { get; }

        public ControllerTestFixture() {
            var builder = WebHost.CreateDefaultBuilder()
                .UseEnvironment("Testing")
                .UseStartup<Startup>();

            var _server = new TestServer(builder);

            Client = _server.CreateClient();
            Client.BaseAddress = new Uri("http://localhost");
        }

        public void Dispose() {}
    }
}