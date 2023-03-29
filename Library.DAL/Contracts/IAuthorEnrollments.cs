using Library.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Contracts
{
    internal interface IAuthorEnrollments
    {
        Task<AuthorsToBooks> GetByIdAsync(int id);
        Task<List<AuthorsToBooks>> GetAllAsync();
        void CreateAuthorToBook(AuthorsToBooks authorsToBooks);
        void DeleteAuthorToBook(AuthorsToBooks authorsToBooks);
    }
}
