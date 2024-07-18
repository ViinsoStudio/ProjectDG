using BusinessLogicSAPP.BL;
using BusinessLogicSAPP.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public readonly UsersBL _bussines;

        public UsersController(UsersBL usersBL)
        {
            _bussines = usersBL;
        }

        [HttpPost("UserRegister")]
        public bool UserRegister(UserDto userDto){

            return _bussines.UserRegister(userDto);
        }
    }
}
