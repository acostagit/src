using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Repository;
using Itau.Filmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Service
{
    public class DevolucaoService : IDevolucaoService
    {
        private readonly IDevolucaoRepository _devolucaoRepository;

        public DevolucaoService(IDevolucaoRepository devolucaoRepository)
        {
            _devolucaoRepository = devolucaoRepository;
        }
        public void Add(Devolucao entity)
        {
            _devolucaoRepository.Add(entity);
        }

        public void Delete(Devolucao entity)
        {
            _devolucaoRepository.Delete(entity);
        }

        public IEnumerable<Devolucao> GetAll()
        {
            return _devolucaoRepository.GetAll();
        }

        public Devolucao GetById(int id)
        {
            return _devolucaoRepository.GetById(id);
        }

        public void Update(Devolucao entity)
        {
            _devolucaoRepository.Update(entity);
        }
    }
}
