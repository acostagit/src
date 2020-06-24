using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Repository;
using Itau.Filmes.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Infra.Repository
{
    class GeneroRepository : RepositoryBase<Genero>, IGeneroRepository
    {
        public GeneroRepository(JuridicoContexto context) : base(context)
        {

        }
    }
}
