using Library.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Contracts
{
    internal interface IBookRepository : IRepositoryBase<Book>
    {
        List<Author> GetAuthors(Book book);
    }
}
