using Itau.Filmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Interfaces.Services
{
    public interface ILocacaoService
    {
        void Add(Locacao entity);
        Locacao GetById(int id);
        IEnumerable<Locacao> GetAll();
        void Update(Locacao entity);
        void Delete(Locacao entity);
    }
}
