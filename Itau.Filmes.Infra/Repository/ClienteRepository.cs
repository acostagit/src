﻿using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Repository;
using Itau.Filmes.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Itau.Filmes.Infra.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(JuridicoContexto context) : base(context)
        {

        }
        public IEnumerable<Cliente> ListAllCliente()
        {
            return _context.Clientes.ToList();
        }

    }
}
