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
        private readonly IDevolucaoService _devolucaoService;
        //private readonly IMapperDevolucao _mapperDevolucao;

        public ApplicationServiceDevolucao(IDevolucaoService devolucaoService)
        {
            _devolucaoService = devolucaoService;
        }

        public void Add(Devolucao Devolucao)
        {
            _devolucaoService.Add(Devolucao);
        }

        public IEnumerable<Devolucao> GetAll()
        {
            return _devolucaoService.GetAll();
        }

        public Devolucao GetById(int id)
        {
            return _devolucaoService.GetById(id);
        }

        public void Remove(Devolucao Devolucao)
        {
            _devolucaoService.Delete(Devolucao);
        }

        public void Update(Devolucao Devolucao)
        {
            _devolucaoService.Update(Devolucao);
        }
    }
}
