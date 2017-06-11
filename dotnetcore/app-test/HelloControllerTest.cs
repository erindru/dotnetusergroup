using System;
using System.Net;
using System.Net.Http;
using Xunit;

namespace app_test {
    public class HelloControllerTest  : IClassFixture<ControllerTestFixture> {

        HttpClient HttpClient;

        public HelloControllerTest(ControllerTestFixture fixture) {
            this.HttpClient = fixture.Client;
        }

        [Fact]
        public async void Get_RedirectsTo_Hello() {
            var response = await this.HttpClient.GetAsync("/");
            
            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
            Assert.Equal("/hello", response.Headers.Location.ToString());
        }

        [Fact]
        public async void GetHello_ReturnsCorrectMessage() {
            var response = await this.HttpClient.GetAsync("/hello");
            
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("Hello, World!", await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async void GetHello_WithNameSpecified_ReturnsCorrectMessageIncludingName() {
            var response = await this.HttpClient.GetAsync("/hello/user");
            
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("Hello, user!", await response.Content.ReadAsStringAsync());
        }

    }
    
}
