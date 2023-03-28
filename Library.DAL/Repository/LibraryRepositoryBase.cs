using Library.DAL.Contracts;
using Library.DAL.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Repository
{
    internal class LibraryRepositoryBase<T> : ILibraryRepositoryBase<T> where T: class
    {
        protected ApplicationLibraryContext libraryContext;

        public LibraryRepositoryBase(ApplicationLibraryContext libraryContext) 
        {
            this.libraryContext = libraryContext;
        }

        public void Create(T item) => libraryContext.Set<T>().Add(item);

        public void Update(T item) => libraryContext.Set<T>().Update(item);

        public void Delete(T item) => libraryContext.Set<T>().Remove(item);

        public IQueryable<T> GetAll() => libraryContext.Set<T>();

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression) => libraryContext.Set<T>().Where(expression);

    }
}
