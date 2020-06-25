using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itau.Filmes.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Itau.Filmes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private readonly IApplicationServiceFilme _applicationServiceFilme;

        public FilmeController(IApplicationServiceFilme applicationServiceFilme)
        {
            _applicationServiceFilme = applicationServiceFilme;
        }


    }
}
