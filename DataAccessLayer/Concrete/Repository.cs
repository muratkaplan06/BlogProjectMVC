using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Abstract;

namespace DataAccessLayer.Concrete
{
    public class Repository<T>:IRepository<T> where T : class, new()
    {
        private readonly Context _context = new Context();
        private readonly DbSet<T> _object;

        public Repository()
        {
            _object = _context.Set<T>();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T entity)
        {
            _object.Add(entity);
           return _context.SaveChanges();
        }

        public int Update(T entity)
        {
            return _context.SaveChanges();
        }

        public int Delete(T entity)
        {
            _object.Remove(entity);
            return _context.SaveChanges();
        }
    }
}
