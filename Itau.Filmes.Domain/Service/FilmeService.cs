using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Repository;
using Itau.Filmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Service
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRepository _filmeRepository;
        public FilmeService(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }
        public void Add(Filme entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Filme entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Filme> GetAll()
        {
            throw new NotImplementedException();
        }

        public Filme GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Filme entity)
        {
            throw new NotImplementedException();
        }
    }
}
