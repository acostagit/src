using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Repository;
using Itau.Filmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Service
{
    class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _EnderecoRepository;

        public EnderecoService(IEnderecoRepository EnderecoRepository)
        {
            _EnderecoRepository = EnderecoRepository;
        }
        public void Add(Endereco entity)
        {
            _EnderecoRepository.Add(entity);
        }

        public void Delete(Endereco entity)
        {
            _EnderecoRepository.Delete(entity);
        }

        public IEnumerable<Endereco> GetAll()
        {
            return _EnderecoRepository.GetAll();
        }

        public Endereco GetById(int id)
        {
            return _EnderecoRepository.GetById(id);
        }

        public void Update(Endereco entity)
        {
            _EnderecoRepository.Update(entity);
        }
    }
}
