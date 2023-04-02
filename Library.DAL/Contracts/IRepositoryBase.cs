using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Contracts
{
    internal interface IRepositoryBase<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetById(Expression<Func<T, bool>> expression);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}
