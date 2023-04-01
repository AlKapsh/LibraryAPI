using Library.DAL.Contracts;
using Library.DAL.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Repository
{
    internal abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DbContext context;

        public RepositoryBase(DbContext context)
        {
            this.context = context;
        }

        public void Create(T item) => context.Set<T>().Add(item);

        public void Update(T item) => context.Set<T>().Update(item);

        public void Delete(T item) => context.Set<T>().Remove(item);

        public IQueryable<T> FindAll() => context.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) => context.Set<T>().Where(expression);
    }
}
