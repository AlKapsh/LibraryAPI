using AutoMapper;
using Library.BAL.Contracts;
using Library.BAL.DataTranferObjects;
using Library.DAL.Contracts;
using Library.DAL.Models;
using Library.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BAL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly ILibraryRepositoryManager repository;
        private readonly IMapper mapper;

        public AuthorService(ILibraryRepositoryManager repository, IMapper mapper)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public void CreateAuthor(AuthorDTO author)
        {
            repository.Author.Create(mapper.Map<Author>(author));

            repository.SaveAsync();
        }

        public void DeleteAuhtor(int id)
        {
            var authorToDelete = repository.Author.GetById(a => a.Id.Equals(id)).SingleOrDefault();
            repository.Author.Delete(authorToDelete);

            repository.SaveAsync();
        }

        public IEnumerable<AuthorDTO> GetAllAuthors()
        {
            var authorsDB = repository.Author.GetAll();
            var ret = mapper.Map<List<AuthorDTO>>(authorsDB);

            return ret;
        }

        public AuthorDTO GetAuthorById(int id)
        {
            var authorDB = repository.Author.GetById(a => a.Id.Equals(id)).SingleOrDefault();

            return mapper.Map<AuthorDTO>(authorDB);
        }

        public void UpdateAuthor(int id, AuthorDTO author)
        {
            var authorDB = repository.Author.GetById(a => a.Id.Equals(id)).SingleOrDefault();
            authorDB = mapper.Map<Author>(author);

            repository.Author.Update(authorDB);
            repository.SaveAsync();
        }
        
    }
}
