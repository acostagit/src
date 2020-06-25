using Itau.Filmes.API;
using Itau.Filmes.API.Controllers;
using Itau.Filmes.Application.Interfaces;
using Itau.Filmes.Domain.Interfaces.Services;
using Itau.Filmes.Domain.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClienteControllerTest
{
    public class ClienteAPITest
    {
        //ClienteController _controller;

        private HttpClient _client;

        public ClienteAPITest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>());

            _client = server.CreateClient();
                
        }

        [Theory]
        [InlineData("GET")]
        public async Task GetCliente(string metod)
        {
            //Arrange
            var request = new HttpRequestMessage(new HttpMethod(metod), "/api/cliente");

            //Act
            var response = await _client.SendAsync(request);

            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

    }
}
