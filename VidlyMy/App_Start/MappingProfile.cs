using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMy.Dto;
using VidlyMy.Models;



namespace VidlyMy.App_Start
{
    public class MappingProfile : Profile
    {
        Mapper.CreateMap<Customer, CustomerDto>();
        Mapper.CreateMap<CustomerDto, Customer>();
    }
}