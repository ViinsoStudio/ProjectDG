using AutoMapper;
using BusinessLogicSAPP.Models.Dto;
using DataAccessSAPP.Entities;
using DataAccessSAPP.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicSAPP.BL
{
    public class UsersBL
    {
        private readonly IMapper _mapper;

        public readonly UsersQueries _queries;
        public UsersBL(UsersQueries queries)
        {
            _queries = queries;
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            _mapper = mapperConfig.CreateMapper();
        }
        /// <summary>
        /// Se registra un usuario nuevo en la base de datos
        /// </summary>
        /// <param name="userDto">Datos del usuario a registrar</param>
        /// <returns>True si el registro es exitoso o false si el registro es fallido</returns>
        public bool UserRegister(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            return _queries.UserRegister(user);
        }
        /// <summary>
        /// Se obtiene el listado de los usuarios registrados en la app
        /// </summary>
        /// <returns>Retorna el listado de usuarios registrados</returns>
        public List<UserDto> GetRegisteredUsers()
        {
            var users = _queries.GetRegisteredUsers();
            var usersDto = _mapper.Map<List<UserDto>>(users);

            return usersDto;
        }
        /// <summary>
        /// Trae el listado de los paises en la base de datos
        /// </summary>
        /// <returns>Listado de paises</returns>
        public List<CountryDto> GetCountries()
        {
            var contriesList = _queries.GetCountries();
            var contriesListDto = _mapper.Map<List<CountryDto>>(contriesList);

            return contriesListDto;
        }
        /// <summary>
        /// Trae el listado de Departamentos, Estados o Provincias por país
        /// </summary>
        /// <param name="countryId">Dato empleado para hacer el filtro de la información</param>
        /// <returns>Listado de Departamentos, Estados o Provincias del país seleccionado</returns>
        public List<DepStaProDto> GetDepStaProsByCountry(int countryId)
        {
            var depStaProList = _queries.GetDepStaProsByCountry(countryId);
            var depStaProListDto = _mapper.Map<List<DepStaProDto>>(depStaProList);

            return depStaProListDto;
        }
        /// <summary>
        /// Consulta del listado de Ciudades o Municipios por Departamento, Estado o Provincia
        /// </summary>
        /// <param name="DepStaProId">Dato empleado para realizar el filtro</param>
        /// <returns>Listado de ciudades o municipios</returns>
        public List<CitMunDto> GetCitMunsByDepStaPro(int DepStaProId)
        {
            var citMunList = _queries.GetCitMunsByDepStaPro(DepStaProId);
            var citMunListDto = _mapper.Map<List<CitMunDto>>(citMunList);

            return citMunListDto;
        }
    }
}
