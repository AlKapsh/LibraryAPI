using Library.DAL.Contracts;
using Library.DAL.EFCore;
using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Repository
{
    internal class ReaderRepository : LibraryRepositoryBase<Reader>, IReaderRepository
    {
        public ReaderRepository(ApplicationLibraryContext libraryContext) : base(libraryContext) { }
        public void CreateReader(Reader reader) => Create(reader);

        public void DeleteReader(Reader reader) => Delete(reader);

        public async Task<Reader> GetAllAsync() => await GetAllAsync();

        public async Task<Reader> GetByIdAsync(int id) => 
            await GetByCondition(reader => reader.Id.Equals(id)).SingleOrDefaultAsync();
    }
}
