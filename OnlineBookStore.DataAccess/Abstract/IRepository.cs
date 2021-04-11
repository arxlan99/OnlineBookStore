using OnlineBookStore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OnlineBookStore.DataAccess.Abstract
{
    public interface IRepository<T> where T : IEntity
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
