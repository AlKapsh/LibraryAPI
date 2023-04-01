using Library.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Contracts
{
    internal interface IIssuanceRepository : IRepositoryBase<Issuance>
    {
        Task<Issuance> GetByIdAsync(int id);
        Task<List<Issuance>> GetAllAsync();
        void CreateIssuance(Issuance issuance);
        void DeleteIssuance(Issuance issuance);
    }
}
