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
        /// <summary>
        /// use to create model mapping profile with AutoMApper
        /// </summary>
        public ModelMappingProfile() 
        {
            CreateMap<Customer, CustomerDto>();
            //CreateMap<StateDto, StateModel>();
        }       
    }
}
