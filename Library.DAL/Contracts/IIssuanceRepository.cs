using Library.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Contracts
{
    internal interface IIssuanceRepository
    {
        Task<Issuance> GetByIdAsync(int id);
        Task<Issuance> GetAllAsync();
        Task CreateIssuance(Issuance publisher);
        Task DeleteIssuance(int id);
    }
}
