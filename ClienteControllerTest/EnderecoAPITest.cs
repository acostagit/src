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
    public class EnderecoAPITest
    {
        private HttpClient _client;

        public EnderecoAPITest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>());

            _client = server.CreateClient();

        }

        [Theory]
        [InlineData("GET")]
        public async Task GetEndereco(string metod)
        {
            //Arrange
            var request = new HttpRequestMessage(new HttpMethod(metod), "/api/endereco");

            //Act
            var response = await _client.SendAsync(request);

            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
