using Library.DAL.Contracts;
using Library.DAL.EFCore;
using Library.DAL.Models;

namespace Library.DAL.Repository
{
    internal class IssuanceRepository : RepositoryBase<Issuance>, IIssuanceRepository
    {

        public IssuanceRepository(ApplicationLibraryContext libraryContext) : base(libraryContext) { }

        public async Task<Issuance> GetByIdAsync(int id) =>
            GetById(issuance => issuance.Id.Equals(id)).SingleOrDefault();
    }
}
