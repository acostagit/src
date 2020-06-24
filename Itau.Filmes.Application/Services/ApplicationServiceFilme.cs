using Itau.Filmes.Application.Interfaces;
using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Application.Services
{
    public class ApplicationServiceFilme : IApplicationServiceFilme
    {
        private readonly IFilmeService _filmeService;

        public ApplicationServiceFilme(IFilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        public void Add(Filme Filme)
        {
            _filmeService.Add(Filme);
        }

        public IEnumerable<Filme> GetAll()
        {
            return _filmeService.GetAll();
        }

        public Filme GetById(int id)
        {
            return _filmeService.GetById(id);
        }

        public void Remove(Filme Filme)
        {
            _filmeService.Delete(Filme);
        }

        public void Update(Filme Filme)
        {
            _filmeService.Update(Filme);
        }
    }
}
