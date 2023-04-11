using Library.DAL.Contracts;
using Library.DAL.EFCore;
using Library.DAL.Models;

namespace Library.DAL.Repository
{
    internal class PublisherRepository : RepositoryBase<Publisher>, IPublisherRepository
    {
        public PublisherRepository(ApplicationLibraryContext libraryContext) : base(libraryContext) { }

        public async Task<Publisher> GetById(int id) =>
            GetById(publisher => publisher.Id.Equals(id)).SingleOrDefault();
    }
}
