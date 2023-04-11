using System.Linq.Expressions;

namespace Library.DAL.Contracts
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetById(Expression<Func<T, bool>> expression);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}
