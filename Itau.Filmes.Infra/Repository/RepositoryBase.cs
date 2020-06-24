using Itau.Filmes.Domain.Interfaces.Repository;
using Itau.Filmes.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Infra.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly JuridicoContexto _context;

        public RepositoryBase(JuridicoContexto contexto)
        {
            _context = contexto;
        }
        public virtual TEntity Add(TEntity entity)
        {
            //_context.Set<TEntity>.Add(entity);
            //_context.SaveChanges();
            //return entity;

            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
