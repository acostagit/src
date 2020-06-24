using Itau.Filmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Application.Interfaces
{
    public interface IApplicationServiceLocacao
    {
        void Add(Locacao Locacao);

        Locacao GetById(int id);

        IEnumerable<Locacao> GetAll();

        void Update(Locacao Locacao);

        void Remove(Locacao Locacao);
    }
}
