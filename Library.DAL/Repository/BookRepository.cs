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
    internal class BookRepository : LibraryRepositoryBase<Book>, IBookRepository
    {

        public BookRepository(ApplicationLibraryContext libraryContext) : base(libraryContext) { }

        public void CreateBook(Book book) => Create(book);

        public void DeleteBook(Book book) => Delete(book);

        public async Task<List<Book>> GetAllAsync() => await FindAll().ToListAsync();

        public async Task<Book> GetByIdAsync(int id) => 
            await FindByCondition(book => book.Id.Equals(id)).SingleOrDefaultAsync();

    }
}
