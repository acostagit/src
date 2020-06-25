using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Repository;
using Itau.Filmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiClienteTest
{
    public class ClienteServiceFake : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        private readonly List<Cliente> _cliente;
        public CompraServiceFake()
        {
            var clientes = new Cliente[]
           {
                new Cliente
                {
                    CodCliente=100,
                    CPF="12345678914",
                    dsCliente="Maria Torres",
                    Endereco = new Endereco(),
                    Email="maria@teste.com.br",
                    Ativo = true
                },
                new Cliente
                {
                    CodCliente=200,
                    CPF="12345678915",
                    dsCliente="Luzia Silva",
                    Endereco = new Endereco(),
                    Email="luzia@teste.com.br",
                    Ativo = true
                }
           };
        }

        public void Add(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
