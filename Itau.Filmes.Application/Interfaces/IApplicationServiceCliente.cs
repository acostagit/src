using Itau.Filmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(Cliente cliente);

        Cliente GetById(int id);

        IEnumerable<Cliente> GetAll();

        void Update(Cliente cliente);

        void Remove(Cliente cliente);

    }
}
