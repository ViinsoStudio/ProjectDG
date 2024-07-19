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

        [HttpGet("GetRegisteredUsers")]

        public List<UserDto> GetRegisteredUsers()
        {
            return _bussines.GetRegisteredUsers();
        }

        [HttpGet("GetCountries")]
        public List<CountryDto> GetCountries()
        {
            return _bussines.GetCountries();
        }

        [HttpGet("GetDepStaProsByCountry")]
        public List<DepStaProDto> GetDepStaProsByCountry(int countryId)
        {
            return _bussines.GetDepStaProsByCountry(countryId);
        }

        [HttpGet("GetCitMunsByDepStaPro")]
        public List<CitMunDto> GetCitMunsByDepStaPro(int DepStaProId)
        {
            return _bussines.GetCitMunsByDepStaPro(DepStaProId);
        }
    }
}
