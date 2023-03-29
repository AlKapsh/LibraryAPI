using Library.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Contracts
{
    internal interface IAuthorRepository
    {
        Task<Author> GetByIdAsync(int id);
        Task<List<Author>> GetAllAsync();
        void CreateAuthorToBook(Author author);
        void DeleteAuthor(Author author);
    }
}
