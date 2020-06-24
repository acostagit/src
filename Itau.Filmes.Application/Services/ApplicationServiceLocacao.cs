using Itau.Filmes.Application.Interfaces;
using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Application.Services
{
    public class ApplicationServiceLocacao: IApplicationServiceLocacao
    {
        private readonly ILocacaoService _LocacaoService;

        public ApplicationServiceLocacao(ILocacaoService LocacaoService)
        {
            _LocacaoService = LocacaoService;
        }

        public void Add(Locacao Locacao)
        {
            _LocacaoService.Add(Locacao);
        }

        public IEnumerable<Locacao> GetAll()
        {
            return _LocacaoService.GetAll();
        }

        public Locacao GetById(int id)
        {
            return _LocacaoService.GetById(id);
        }

        public void Remove(Locacao Locacao)
        {
            _LocacaoService.Delete(Locacao);
        }

        public void Update(Locacao Locacao)
        {
            _LocacaoService.Update(Locacao);
        }
    }
}
