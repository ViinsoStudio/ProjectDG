using BusinessLogicSAPP.BL;
using BusinessLogicSAPP.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        public readonly AnimalsBL _bussines;

        public AnimalsController(AnimalsBL animalsBl)
        {
            _bussines = animalsBl;
        }

        [HttpPost("AnimalsRegister")]
        public bool AnimalsRegister(List<AnimalDto> animalsData)
        {
            return _bussines.AnimalsRegister(animalsData);
        }

        [HttpGet("GetAnimalByName")]
        public AnimalDto GetAnimalByName(int userId, string animalName)
        {
            return _bussines.GetAnimalByName(userId, animalName);
        }

        [HttpGet("GetAnimalsByUser")]
        public List<AnimalDto> GetAnimalsByUser(int userId)
        {
            return _bussines.GetAnimalsByUser(userId);
        }
    }
}
