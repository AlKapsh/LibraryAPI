using Library.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Contracts
{
    internal interface IAuthorsToBookRepository
    {
        Task<AuthorsToBooks> GetByIdAsync(int id);
        Task<AuthorsToBooks> GetAllAsync();
        Task CreateAuthorToBook(AuthorsToBooks authorsToBooks);
        Task DeleteAuthorToBook(AuthorsToBooks authorsToBooks);
    }
}
