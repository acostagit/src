using Itau.Filmes.API;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClienteControllerTest
{
    public class FimeAPITest
    {
        private HttpClient _client;

        [Fact]
        public void FilmeAdicionar()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>());

            _client = server.CreateClient();

        }

        [Theory]
        [InlineData("GET")]
        public async Task GetFilme(string metod)
        {
            //Arrange
            var request = new HttpRequestMessage(new HttpMethod(metod), "/api/filme");

            //Act
            var response = await _client.SendAsync(request);

            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
