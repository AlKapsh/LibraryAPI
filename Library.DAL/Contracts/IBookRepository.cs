using Library.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Contracts
{
    internal interface IBookRepository : IRepositoryBase<Book>
    {
        Task<Book> GetByIdAsync(int id);
        Task<List<Book>> GetAllAsync();
        void CreateBook(Book book);
        void DeleteBook(Book book);
        List<Author> GetAuthors(Book book);
    }
}
