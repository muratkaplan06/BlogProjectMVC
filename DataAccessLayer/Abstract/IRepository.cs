using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    { 
        List<T> List();
        List<T> List(Expression<Func<T, bool>> filter);
        T GetById(int id);
        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}
