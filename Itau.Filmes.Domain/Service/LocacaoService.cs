﻿using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Repository;
using Itau.Filmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Service
{
    public class LocacaoService : ILocacaoService
    {
        private readonly ILocacaoRepository _locacaoRepository;

        public LocacaoService(ILocacaoRepository locacaoRepository)
        {
            _locacaoRepository = locacaoRepository;
        }
        public void Add(Locacao entity)
        {
            _locacaoRepository.Add(entity);
        }

        public void Delete(Locacao entity)
        {
            // _locacaoRepository.Delete(entity);

            entity.Ativo = false;
            Update(entity);
        }

        public IEnumerable<Locacao> GetAll()
        {
            return _locacaoRepository.GetAll();
        }

        public Locacao GetById(int id)
        {
            var locacao =  _locacaoRepository.GetById(id);

            if (locacao != null)
                new Exception("Filme já alugado. Por favor, alugue outro!");

            return locacao;

        }

        public void Update(Locacao entity)
        {
            _locacaoRepository.Update(entity);
        }
    }
}
