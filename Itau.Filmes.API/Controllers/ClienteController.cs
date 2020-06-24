using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itau.Filmes.Application.Interfaces;
using Itau.Filmes.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Itau.Filmes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;

        public ClienteController(IApplicationServiceCliente applicationServiceCliente)
        {
            _applicationServiceCliente = applicationServiceCliente;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            return Ok(_applicationServiceCliente.GetAll());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            try
            {
                if (cliente == null)
                {
                    return NotFound();
                }

                _applicationServiceCliente.Add(cliente);
                return Ok("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceCliente.GetById(id));
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cliente cliente)
        {
            try
            {
                if (cliente == null)
                    return NotFound();

                _applicationServiceCliente.Update(cliente);
                return Ok("Cliente atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Cliente cliente)
        {
            try
            {
                if (cliente == null)
                    return NotFound();

                _applicationServiceCliente.Remove(cliente);
                return Ok("Cliente deletado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
