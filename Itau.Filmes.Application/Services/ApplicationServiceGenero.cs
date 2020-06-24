using Itau.Filmes.Application.Interfaces;
using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Itau.Generos.Application.Services
{
    public class ApplicationServiceGenero: IApplicationServiceGenero
    {
        private readonly IGeneroService _generoService;

        public ApplicationServiceGenero(IGeneroService generoService)
        {
            _generoService = generoService;
        }

        public void Add(Genero Genero)
        {
            _generoService.Add(Genero);
        }

        public IEnumerable<Genero> GetAll()
        {
            return _generoService.GetAll();
        }

        public Genero GetById(int id)
        {
            return _generoService.GetById(id);
        }

        public void Remove(Genero Genero)
        {
            _generoService.Delete(Genero);
        }

        public void Update(Genero Genero)
        {
            _generoService.Update(Genero);
        }
    }
}
