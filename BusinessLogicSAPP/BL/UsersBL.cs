using AutoMapper;
using BusinessLogicSAPP.Models.Dto;
using DataAccessSAPP.Entities;
using DataAccessSAPP.Queries;
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
    }
}
