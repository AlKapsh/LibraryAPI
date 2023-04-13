namespace Library.DAL.Contracts
{
    public interface ILibraryRepositoryManager
    {
        IAuthorRepository Author { get; }
        IBookRepository Book { get; }
        IIssuanceRepository Issuance { get; }
        IPublisherRepository Publisher { get; }
        IReaderRepository Reader { get; }

        Task SaveAsync();

    }
}
