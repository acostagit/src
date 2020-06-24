using Itau.Filmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Interfaces.Services
{
    public interface IClienteService
    {
        void Add(Cliente entity);
        Cliente GetById(int id);
        IEnumerable<Cliente> GetAll();
        void Update(Cliente entity);
        void Delete(Cliente entity);
    }
}
