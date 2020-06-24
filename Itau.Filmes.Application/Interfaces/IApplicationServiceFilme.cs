using Itau.Filmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Application.Interfaces
{
   public interface IApplicationServiceFilme
    {
        void Add(Filme Filme);

        Filme GetById(int id);

        IEnumerable<Filme> GetAll();

        void Update(Filme Filme);

        void Remove(Filme Filme);
    }
}
