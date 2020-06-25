using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Repository;
using Itau.Filmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Service
{
    class GeneroService : IGeneroService
    {
        private readonly IGeneroRepository _generoRepository;

        public GeneroService(IGeneroRepository generoRepository)
        {
            _generoRepository = generoRepository;
        }
        public void Add(Genero entity)
        {
            _generoRepository.Add(entity);
        }

        public void Delete(Genero entity)
        {
            //_generoRepository.Delete(entity);

            entity.Ativo = false;
            Update(entity);
        }

        public IEnumerable<Genero> GetAll()
        {
            return _generoRepository.GetAll();
        }

        public Genero GetById(int id)
        {
            return _generoRepository.GetById(id);
        }

        public void Update(Genero entity)
        {
            _generoRepository.Update(entity);
        }
    }
}
