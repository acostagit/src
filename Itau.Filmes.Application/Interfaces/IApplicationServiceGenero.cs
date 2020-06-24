using Itau.Filmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Application.Interfaces
{
    public interface IApplicationServiceGenero
    {
        void Add(Genero Genero);

        Genero GetById(int id);

        IEnumerable<Genero> GetAll();

        void Update(Genero Genero);

        void Remove(Genero Genero);
    }
}
