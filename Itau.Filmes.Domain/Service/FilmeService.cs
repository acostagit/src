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
            _filmeRepository.Add(entity);
        }

        public void Delete(Filme entity)
        {
            // _filmeRepository.Delete(entity);
            entity.Ativo = false;
            Update(entity);
        }

        public IEnumerable<Filme> GetAll()
        {
            return _filmeRepository.GetAll();
        }

        public Filme GetById(int id)
        {
            return _filmeRepository.GetById(id);
        }

        public void Update(Filme entity)
        {
            _filmeRepository.Update(entity);
        }
    }
}
