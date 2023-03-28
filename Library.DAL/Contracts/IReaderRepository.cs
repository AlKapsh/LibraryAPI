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
        Task<Reader> GetByIdAsync(int id);
        Task<Reader> GetAllAsync();

        void CreateReader(Reader reader);
        void DeleteReader(Reader reader);
    }
}
