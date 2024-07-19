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
    public class AnimalsBL
    {
        private readonly IMapper _mapper;

        public readonly AnimalsQueries _queries;
        public AnimalsBL(AnimalsQueries queries)
        {
            _queries = queries;
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            _mapper = mapperConfig.CreateMapper();
        }
        /// <summary>
        /// Función para registrar los animales ingresados por el usuario
        /// </summary>
        /// <param name="animalsData">Listado de animales que se registran</param>
        /// <returns>True si el registro es exitoso y false si es fallido</returns>
        public bool AnimalsRegister(List<AnimalDto> animalsData)
        {
            var animalsList = _mapper.Map<List<Animal>>(animalsData);

            return _queries.AnimalsRegister(animalsList);
        }
        /// <summary>
        /// Se obtiene la información de un animal
        /// </summary>
        /// <param name="userId">Este dato filtra la información por usuario</param>
        /// <param name="animalName">Este dato filtra la información por el nombre del animal</param>
        /// <returns>Retorna la información del animal correspondiente al nombre</returns>
        public AnimalDto GetAnimalByName(int userId, string animalName)
        {
            var animalData = _queries.GetAnimalByName(userId, animalName);
            var animalDataDto = _mapper.Map<AnimalDto>(animalData);

            return animalDataDto;
        }
        /// <summary>
        /// Función para obtener la información de los animales por usuario
        /// </summary>
        /// <param name="userId">Id del usuario para filtrar la información</param>
        /// <returns>retorna el listado de animales del usuario</returns>
        public List<AnimalDto> GetAnimalsByUser(int userId)
        {
            var animalsList = _queries.GetAnimalsByUser(userId);
            var animalsListDto = _mapper.Map<List<AnimalDto>>(animalsList);

            return animalsListDto;
        }
    }
}
