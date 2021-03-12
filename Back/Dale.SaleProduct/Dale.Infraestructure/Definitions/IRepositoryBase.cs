using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dale.Infraestructure.Definitions
{
    public interface IRepositoryBase<T>
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
    }
}
