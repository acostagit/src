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
        private readonly ILocacaoService _locacaoService;

        public ApplicationServiceLocacao(ILocacaoService locacaoService)
        {
            _locacaoService = locacaoService;
        }

        public void Add(Locacao Locacao)
        {
            _locacaoService.Add(Locacao);
        }

        public IEnumerable<Locacao> GetAll()
        {
            return _locacaoService.GetAll();
        }

        public Locacao GetById(int id)
        {
            return _locacaoService.GetById(id);
        }

        public void Remove(Locacao Locacao)
        {
            _locacaoService.Delete(Locacao);
        }

        public void Update(Locacao Locacao)
        {
            _locacaoService.Update(Locacao);
        }
    }
}
