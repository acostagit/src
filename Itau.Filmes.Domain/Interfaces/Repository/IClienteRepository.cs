using Itau.Filmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    {
        IEnumerable<Cliente> ListAllCliente();
    }
}
