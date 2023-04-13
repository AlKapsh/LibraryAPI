using Library.DAL.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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

        public IEnumerable<T> GetAll() => context.Set<T>();

        public IEnumerable<T> GetById(Expression<Func<T, bool>> expression) => context.Set<T>().Where(expression);
    }
}
