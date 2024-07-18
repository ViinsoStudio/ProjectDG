using AutoMapper;
using BusinessLogicSAPP.Models.Dto;
using DataAccessSAPP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicSAPP
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }    
    }
}
