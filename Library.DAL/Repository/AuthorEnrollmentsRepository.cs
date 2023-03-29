using Library.DAL.Contracts;
using Library.DAL.EFCore;
using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Repository
{
    internal class AuthorEnrollments : LibraryRepositoryBase<AuthorsToBooks>, IAuthorEnrollments
    {
        public AuthorEnrollments(ApplicationLibraryContext libraryContext): base(libraryContext) { }

        public void CreateAuthorToBook(Models.AuthorsToBooks authorsToBooks)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuthorToBook(Models.AuthorsToBooks authorsToBooks)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AuthorsToBooks>> GetAllAsync() => await FindAll().ToListAsync();

        public async Task<AuthorsToBooks> GetByIdAsync(int id) => 
            await FindByCondition(item => item.Id.Equals(id)).SingleOrDefaultAsync();
    }
}
