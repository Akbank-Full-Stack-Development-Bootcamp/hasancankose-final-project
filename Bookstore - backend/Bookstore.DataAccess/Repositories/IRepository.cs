using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.DataAccess.Repositories
{
    public interface IRepository<TEntity> where TEntity : IEntity, new()
    {
        IList<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(int id);
    }
}
