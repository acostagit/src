using Itau.Filmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Interfaces.Services
{
    public interface IEnderecoService
    {
        void Add(Endereco entity);
        Endereco GetById(int id);
        IEnumerable<Endereco> GetAll();
        void Update(Endereco entity);
        void Delete(Endereco entity);
    }
}
