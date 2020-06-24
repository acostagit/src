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
        private readonly IEnderecoService _EnderecoService;

        public ApplicationServiceEndereco(IEnderecoService EnderecoService)
        {
            _EnderecoService = EnderecoService;
        }

        public void Add(Endereco Endereco)
        {
            _EnderecoService.Add(Endereco);
        }

        public IEnumerable<Endereco> GetAll()
        {
            return _EnderecoService.GetAll();
        }

        public Endereco GetById(int id)
        {
            return _EnderecoService.GetById(id);
        }

        public void Remove(Endereco Endereco)
        {
            _EnderecoService.Delete(Endereco);
        }

        public void Update(Endereco Endereco)
        {
            _EnderecoService.Update(Endereco);
        }
    }
}
