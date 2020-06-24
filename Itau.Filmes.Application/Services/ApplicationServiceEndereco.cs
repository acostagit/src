using Itau.Filmes.Application.Interfaces;
using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Application.Services
{
    public class ApplicationServiceEndereco: IApplicationServiceEndereco
    {
        private readonly IEnderecoService _enderecoService;

        public ApplicationServiceEndereco(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        public void Add(Endereco Endereco)
        {
            _enderecoService.Add(Endereco);
        }

        public IEnumerable<Endereco> GetAll()
        {
            return _enderecoService.GetAll();
        }

        public Endereco GetById(int id)
        {
            return _enderecoService.GetById(id);
        }

        public void Remove(Endereco Endereco)
        {
            _enderecoService.Delete(Endereco);
        }

        public void Update(Endereco Endereco)
        {
            _enderecoService.Update(Endereco);
        }
    }
}
