using Itau.Devolucaos.Application.Interfaces;
using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Application.Services
{
    public class ApplicationServiceDevolucao: IApplicationServiceDevolucao
    {
        private readonly IDevolucaoService _DevolucaoService;
        //private readonly IMapperDevolucao _mapperDevolucao;

        public ApplicationServiceDevolucao(IDevolucaoService DevolucaoService)
        {
            _DevolucaoService = DevolucaoService;
        }

        public void Add(Devolucao Devolucao)
        {
            _DevolucaoService.Add(Devolucao);
        }

        public IEnumerable<Devolucao> GetAll()
        {
            return _DevolucaoService.GetAll();
        }

        public Devolucao GetById(int id)
        {
            return _DevolucaoService.GetById(id);
        }

        public void Remove(Devolucao Devolucao)
        {
            _DevolucaoService.Delete(Devolucao);
        }

        public void Update(Devolucao Devolucao)
        {
            _DevolucaoService.Update(Devolucao);
        }
    }
}
