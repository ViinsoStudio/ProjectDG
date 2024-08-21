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
            CreateMap<Animal, AnimalDto>();
            CreateMap<AnimalDto, Animal>();
            CreateMap<AnimalType, AnimalTypeDto>();
            CreateMap<AnimalTypeDto, AnimalType>();
            CreateMap<CitMun, CitMunDto>();
            CreateMap<CitMunDto, CitMun>();
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
            CreateMap<DepStaPro, DepStaProDto>();
            CreateMap<DepStaProDto, DepStaPro>();
            CreateMap<DocumentType, DocumentTypeDto>();
            CreateMap<DocumentTypeDto, DocumentType>();
            CreateMap<Raza, RazaDto>();
            CreateMap<RazaDto, Raza>();
            CreateMap<ReproductiveStatus, ReproductiveStatusDto>();
            CreateMap<ReproductiveStatusDto, ReproductiveStatus>();
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

        }    
    }
}
