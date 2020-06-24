using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
