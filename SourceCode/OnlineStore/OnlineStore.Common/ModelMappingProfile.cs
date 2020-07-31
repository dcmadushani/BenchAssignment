using AutoMapper;
using OnlineStore.Common.DTO;
using OnlineStore.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Common
{
    public class ModelMappingProfile : Profile
    {
        public ModelMappingProfile() 
        {
            CreateMap<Customer, CustomerDto>();
            //CreateMap<StateDto, StateModel>();
        }       
    }
}
