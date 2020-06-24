using Itau.Filmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Interfaces.Services
{
    public interface IDevolucaoService
    {
        void Add(Devolucao entity);
        Devolucao GetById(int id);
        IEnumerable<Devolucao> GetAll();
        void Update(Devolucao entity);
        void Delete(Devolucao entity);
    }
}
