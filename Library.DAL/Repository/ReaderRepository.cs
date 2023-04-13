using Library.DAL.Contracts;
using Library.DAL.EFCore;
using Library.DAL.Models;

namespace Library.DAL.Repository
{
    internal class ReaderRepository : RepositoryBase<Reader>, IReaderRepository
    {
        public ReaderRepository(ApplicationLibraryContext libraryContext) : base(libraryContext) { }

        public async Task<Reader> GetById(int id)
        {
            var reader = GetById(reader => reader.Id.Equals(id)).SingleOrDefault();
            return reader;
        }
    }
}
