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
    internal class AuthorRepository : LibraryRepositoryBase<Author>, IAuthorRepository
    {

        public AuthorRepository(ApplicationLibraryContext libraryContext) : base(libraryContext) { }
        
        public void CreateAuthorToBook(Author author) => Create(author);

        public void DeleteAuthor(Author author) => Delete(author);

        public async Task<Author> GetAllAsync() => await GetAllAsync();

        public async Task<Author> GetByIdAsync(int id) => 
            await GetByCondition(author => author.Id.Equals(id)).SingleOrDefaultAsync();
    }
}
