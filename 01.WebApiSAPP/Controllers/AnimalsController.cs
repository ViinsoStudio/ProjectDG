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

        [HttpPost("AnimalRegister")]
        public bool AnimalRegister(AnimalDto animalsData)
        {
            return _bussines.AnimalRegister(animalsData);
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

        [HttpGet("GetAnimalTypes")]
        public List<AnimalTypeDto> GetAnimalTypes()
        {
            return _bussines.GetAnimalTypes();
        }

        [HttpGet("GetRazasByAnimalType")]
        public List<RazaDto> GetRazasByAnimalType(int animalTypeId)
        {
            return _bussines.GetRazasByAnimalType(animalTypeId);
        }

        [HttpGet("GetReproductiveStatusByAnimalType")]
        public List<ReproductiveStatusDto> GetReproductiveStatusByAnimalType(int animalTypeId)
        {
            return _bussines.GetReproductiveStatusByAnimalType(animalTypeId);
        }

        [HttpPost("CreateAnimalType")]

        public bool CreateAnimalType(string Name)
        {
            return _bussines.CreateAnimalType(Name);
        }

        [HttpPost("CreateRace")]
        public void CreateRace(string AnimalType, string NewRaceName)
        {
            _bussines.CreateRace(AnimalType, NewRaceName);
        }
    }
}
