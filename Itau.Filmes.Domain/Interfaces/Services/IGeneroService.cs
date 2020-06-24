using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Interfaces.Services
{
    public interface IGeneroService
    {
        void Add(Genero entity);
        Genero GetById(int id);
        IEnumerable<Genero> GetAll();
        void Update(Genero entity);
        void Delete(Genero entity);
    }
}
