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
    internal class IssuanceRepository : LibraryRepositoryBase<Issuance>, IIssuanceRepository
    {

        public IssuanceRepository(ApplicationLibraryContext libraryContext) : base(libraryContext) { }

        public void CreateIssuance(Issuance issuance) => Create(issuance);

        public void DeleteIssuance(Issuance issuance) => Delete(issuance);

        public async Task<Issuance> GetAllAsync() => await GetAllAsync();

        public async Task<Issuance> GetByIdAsync(int id) => 
            await GetByCondition(issuance => issuance.Id.Equals(id)).SingleOrDefaultAsync();
    }
}
