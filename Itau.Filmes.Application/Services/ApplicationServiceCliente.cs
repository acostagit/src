using Itau.Filmes.Application.Interfaces;
using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Itau.Filmes.Application.Services
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IClienteService _clienteService;
        //private readonly IMapperCliente _mapperCliente;

        public ApplicationServiceCliente(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }



        public void Add(Cliente cliente)
        {
            _clienteService.Add(cliente);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _clienteService.GetAll();
        }

        public Cliente GetById(int id)
        {
            return _clienteService.GetById(id);
        }

        public void Remove(Cliente cliente)
        {
            _clienteService.Delete(cliente);
        }

        public void Update(Cliente cliente)
        {
            _clienteService.Update(cliente);
        }
    }
}
