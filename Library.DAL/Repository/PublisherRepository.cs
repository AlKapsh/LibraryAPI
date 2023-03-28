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
    internal class PublisherRepository : LibraryRepositoryBase<Publisher>, IPublisherRepository
    {
        public PublisherRepository(ApplicationLibraryContext libraryContext) : base(libraryContext) { }
        public void CreatePublisher(Publisher publisher) => Create(publisher);

        public void DeletePublisher(Publisher publisher) => Delete(publisher);

        public async Task<Publisher> GetAllAsync() => await GetAllAsync();

        public async Task<Publisher> GetByIdAsync(int id) => 
            await GetByCondition(publisher => publisher.Id.Equals(id)).SingleOrDefaultAsync();
    }
}
