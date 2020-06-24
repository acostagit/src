using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Repository;
using Itau.Filmes.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Itau.Filmes.Infra.Repository
{
    public class FilmeRepository : RepositoryBase<Filme>, IFilmeRepository
    {
        public FilmeRepository(JuridicoContexto context) : base(context)
        {

        }
        public IEnumerable<Filme> ListAllCliente()
        {
            return _context.Filmes.ToList();
        }
    }
}
