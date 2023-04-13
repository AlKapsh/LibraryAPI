using Library.DAL.Contracts;
using Library.DAL.EFCore;
using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;



namespace Library.DAL.Repository
{
    internal class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {

        public AuthorRepository(ApplicationLibraryContext libraryContext) : base(libraryContext) { }

        public async Task<List<Author>> GetAuthorsOfBook(int bookId)
        {
            var authors = await context.Set<Author>()
                .Include(a => a.AuthorsToBooks)
                .ThenInclude(ad => ad.Book)
            .Where(ab => ab.AuthorsToBooks
                .All(b => b.Book.Id.Equals(bookId))).ToListAsync();

            return authors;
        }

        public async Task<Author> GetByIdAsync(int id) =>
            GetById(author => author.Id.Equals(id)).SingleOrDefault();

    }
}
