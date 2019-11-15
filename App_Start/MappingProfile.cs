using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Smartmom4.Models;
using Smartmom4.dtos;

namespace Smartmom4.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer> ();
        }




    }
}