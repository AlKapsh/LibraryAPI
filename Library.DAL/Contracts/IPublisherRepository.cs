using Library.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Contracts
{
    internal interface IPublisherRepository
    {
        Task<Publisher> GetByIdAsync(int id);
        Task<Publisher> GetAllAsync();
        void CreatePublisher(Publisher publisher);
        void DeletePublisher(Publisher publisher);
    }
}
