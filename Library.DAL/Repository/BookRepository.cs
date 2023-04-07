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
    internal class BookRepository : RepositoryBase<Book>, IBookRepository
    {

        public BookRepository(ApplicationLibraryContext libraryContext) : base(libraryContext) { }

        public void CreateBook(Book book) => Create(book);

        public void DeleteBook(Book book) => Delete(book);

        public async Task<List<Book>> GetAllAsync() => GetAll().ToList();

        public List<Author> GetAuthors(Book book)
        {
            List<Author> authors = new();

            foreach(var item in book.AuthorsToBooks)
            {
               authors.Add(item.Author);
            }

            return authors;
        }

        public async Task<Book> GetByIdAsync(int id) => 
            await GetById(book => book.Id.Equals(id))
            .Include(b => b.AuthorsToBooks)
            .ThenInclude(a => a.Author)
            .SingleOrDefaultAsync();

    }
}
