using Itau.Filmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Devolucaos.Application.Interfaces
{
    public interface IApplicationServiceDevolucao
    {
        void Add(Devolucao Devolucao);

        Devolucao GetById(int id);

        IEnumerable<Devolucao> GetAll();

        void Update(Devolucao Devolucao);

        void Remove(Devolucao Devolucao);
    }
}
