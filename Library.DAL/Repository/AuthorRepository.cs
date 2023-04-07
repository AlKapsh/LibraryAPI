using Library.DAL.Contracts;
using Library.DAL.EFCore;
using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Repository
{
    internal class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {

        public AuthorRepository(ApplicationLibraryContext libraryContext) : base(libraryContext) { }
        
        public void CreateAuthorToBook(Author author) => Create(author);

        public void DeleteAuthor(Author author) => Delete(author);

        public async Task<IQueryable<Author>> GetAllAsync() =>  GetAll();

        public IQueryable<Author> GetAllBooks(int bookId)
        {
            return GetAll()
                .Include(a => a.AuthorsToBooks)
                    .ThenInclude(ad => ad.Book)
                .Where(ab => ab.AuthorsToBooks
                    .All(b => b.Book.Id.Equals(bookId)))
                .AsQueryable();
        }

        public async Task<Author> GetByIdAsync(int id) => 
            await GetById(author => author.Id.Equals(id))
            .Include(a => a.AuthorsToBooks)
            .ThenInclude(b => b.Book)
            .SingleOrDefaultAsync();

    }
}
