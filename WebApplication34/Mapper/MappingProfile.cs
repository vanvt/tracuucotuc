using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication34.Data;
using WebApplication34.Models;

namespace WebApplication34.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<TransactionVM, Transaction>();
            CreateMap<Transaction, TransactionVM>();
        }
    }
}
