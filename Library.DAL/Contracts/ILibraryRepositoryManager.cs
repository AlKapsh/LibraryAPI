using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Contracts
{
    internal interface ILibraryRepositoryManager
    {
        IAuthorRepository Author { get; }
        IAuthorEnrollments AuthorsToBooks { get; }
        IBookRepository Book { get; }
        IIssuanceRepository Issuance { get; }
        IPublisherRepository Publisher { get; }
        IReaderRepository Reader { get; }

        Task SaveAsync();

    }
}
