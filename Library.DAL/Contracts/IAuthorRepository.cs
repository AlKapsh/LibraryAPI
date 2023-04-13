using Library.DAL.Models;

namespace Library.DAL.Contracts
{
    public interface IAuthorRepository : IRepositoryBase<Author>
    {
        Task<List<Author>> GetAuthorsOfBook(int bookId);
    }
}
