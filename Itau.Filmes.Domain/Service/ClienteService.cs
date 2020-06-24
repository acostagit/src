using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Repository;
using Itau.Filmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Itau.Filmes.Domain.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public void Add(Cliente entity)
        {
            _clienteRepository.Add(entity);
        }

        public void Delete(Cliente entity)
        {
            _clienteRepository.Delete(entity);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente GetById(int id)
        {
            return _clienteRepository.GetById(id);
        }

        public void Update(Cliente entity)
        {
            _clienteRepository.Update(entity);
        }
    }
}
