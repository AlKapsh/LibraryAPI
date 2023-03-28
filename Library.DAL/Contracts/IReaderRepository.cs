using Library.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Contracts
{
    internal interface IReaderRepository
    {
        Task<Author> GetByIdAsync(int id);
        Task<Author> GetAllAsync();

        Task CreateReader(Reader reader);
        Task DeleteReader(int id);
    }
}
