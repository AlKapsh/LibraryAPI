using Library.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Contracts
{
    internal interface IBookRepository
    {
        Task<Book> GetByIdAsync(int id);
        Task<Book> GetAllAsync();
        Task CreateBook(Book book);
        Task DeleteBook(int id);
    }
}
