using AutoMapper;
using Library.BAL.DataTranferObjects;
using Library.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BAL.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<AuthorDTO, Author>().ReverseMap();
            CreateMap<IssuanceDTO, Issuance>().ReverseMap();
            CreateMap<BookDTO, Book>().ReverseMap();
            CreateMap<PublisherDTO, Publisher>().ReverseMap();
            CreateMap<ReaderDTO, Reader>().ReverseMap();
        }
    }
}
