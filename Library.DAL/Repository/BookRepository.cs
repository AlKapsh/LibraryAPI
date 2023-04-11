using Library.DAL.Contracts;
using Library.DAL.EFCore;
using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;


namespace Library.DAL.Repository
{
    internal class BookRepository : RepositoryBase<Book>, IBookRepository
    {

        public BookRepository(ApplicationLibraryContext libraryContext) : base(libraryContext) { }

        public async Task<List<Book>> GetBooksOfAuthor(int authorId)
        {
            var authors = await context.Set<Book>()
                .Include(book => book.AuthorsToBooks)
                    .ThenInclude(atb => atb.Author.Id.Equals(authorId))
                .Where(book => book.AuthorsToBooks
                    .All(atb => atb.Author.Id.Equals(authorId)))
                .ToListAsync();

            return authors;
        }

        public async Task<Book> GetByIdAsync(int id) =>
            GetById(book => book.Id.Equals(id)).SingleOrDefault();

    }
}
