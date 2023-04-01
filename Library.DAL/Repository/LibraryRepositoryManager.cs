using Library.DAL.Contracts;
using Library.DAL.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Repository
{

    internal class LibraryRepositoryManager : ILibraryRepositoryManager
    {
        ApplicationLibraryContext libraryContext;
        private IAuthorRepository authorRepository;
        private IBookRepository bookRepository;
        private IIssuanceRepository issuanceRepository;
        private IReaderRepository readerRepository;
        private IPublisherRepository publisherRepository;

        public LibraryRepositoryManager(ApplicationLibraryContext libraryContext)
        {
            this.libraryContext = libraryContext;
        }

        public IAuthorRepository Author
        {
            get
            {
                if (authorRepository == null)
                {
                    authorRepository = new AuthorRepository(libraryContext);
                }

                return authorRepository;
            }
        }

        public IBookRepository Book
        {
            get
            {
                if (bookRepository == null)
                {
                    bookRepository = new BookRepository(libraryContext);
                }

                return bookRepository;
            }
        }

        public IIssuanceRepository Issuance
        {
            get
            {
                if (issuanceRepository == null)
                {
                    issuanceRepository = new IssuanceRepository(libraryContext);
                }

                return issuanceRepository;
            }
        }

        public IPublisherRepository Publisher
        {
            get
            {
                if (publisherRepository == null)
                {
                    publisherRepository = new PublisherRepository(libraryContext);
                }

                return publisherRepository;
            }
        }

        public IReaderRepository Reader
        {
            get
            {
                if (readerRepository == null)
                {
                    readerRepository = new ReaderRepository(libraryContext);
                }

                return readerRepository;
            }
        }

        public async Task SaveAsync() => await libraryContext.SaveChangesAsync();
    }
}
