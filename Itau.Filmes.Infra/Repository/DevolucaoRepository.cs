using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Repository;
using Itau.Filmes.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Infra.Repository
{
    public class DevolucaoRepository : RepositoryBase<Devolucao>, IDevolucaoRepository
    {
        public DevolucaoRepository(JuridicoContexto context) : base(context)
        {

        }

        public string Devolver(Devolucao devolucao)
        {
            throw new NotImplementedException();
        }
    }
}
