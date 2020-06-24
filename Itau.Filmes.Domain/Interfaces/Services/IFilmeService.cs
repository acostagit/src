using Itau.Filmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Interfaces.Services
{
    public interface IFilmeService
    {
        void Add(Filme entity);
        Filme GetById(int id);
        IEnumerable<Filme> GetAll();
        void Update(Filme entity);
        void Delete(Filme entity);
    }
}
