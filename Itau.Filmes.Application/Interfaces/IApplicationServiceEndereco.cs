using Itau.Filmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Application.Interfaces
{
    public interface IApplicationServiceEndereco
    {
        void Add(Endereco Endereco);

        Endereco GetById(int id);

        IEnumerable<Endereco> GetAll();

        void Update(Endereco Endereco);

        void Remove(Endereco Endereco);
    }
}
