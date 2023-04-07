using AutoMapper.Configuration.Conventions;
using Library.BAL.DataTranferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BAL.Contracts
{
    public interface IAuthorService
    {
        IEnumerable<AuthorDTO> GetAllAuthors();
        AuthorDTO GetAuthorById(int id);
        void CreateAuthor(AuthorDTO author);
        void DeleteAuhtor(int id);
        void UpdateAuthor(int id, AuthorDTO author);
    }
}
