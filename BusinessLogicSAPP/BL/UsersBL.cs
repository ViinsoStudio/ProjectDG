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
        UsersQueries _queries;
        public UsersBL(UsersQueries queries)
        {
            _queries = queries;
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            _mapper = mapperConfig.CreateMapper();
        }

        public bool UserRegister(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            return _queries.UserRegister(user);
        }
    }
}
