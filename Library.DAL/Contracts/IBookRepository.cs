using Library.DAL.Models;

namespace Library.DAL.Contracts
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        Task<List<Book>> GetBooksOfAuthor(int authorId);
    }
}
