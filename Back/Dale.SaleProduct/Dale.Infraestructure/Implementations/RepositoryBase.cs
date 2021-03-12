using System;
using System.Linq;
using System.Linq.Expressions;
using Dale.Infraestructure.Definitions;
using Dale.Infraestructure.Definitions.Context;
using Microsoft.EntityFrameworkCore;

namespace Dale.Infraestructure.Implementations
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        private readonly DbContext _dbContext;

        public RepositoryBase(IDaleContext dbContext)
        {
            _dbContext = dbContext as DbContext;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Delete(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Deleted;
            _dbContext.SaveChanges();
        }

        public IQueryable<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public void Create(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Added;
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
