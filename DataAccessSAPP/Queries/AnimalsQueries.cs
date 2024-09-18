using DataAccessSAPP.Context;
using DataAccessSAPP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessSAPP.Queries
{
    public class AnimalsQueries
    {
        private readonly AppDbContext _context;
        public AnimalsQueries(AppDbContext context) 
        {
            _context = context;
        }

        public bool AnimalRegister(Animal animalsData)
        {
            try
            {
                _context.Animals.Add(animalsData);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Animal GetAnimalByName(int userId, string animalName)
        {
            var animalData = _context.Animals.FirstOrDefault(a => a.UserId == userId && a.Name == animalName);

            return animalData != null ? animalData : new Animal();
        }

        public List<Animal> GetAnimalsByUser(int userId)
        {
            var animalsList = _context.Animals.Where(a => a.UserId == userId).ToList();

            return animalsList != null ? animalsList : new List<Animal>();
        }

        public List<AnimalType> GetAnimalTypes()
        {
            return _context.AnimalTypes.ToList();
        }

        public List<Raza> GetRazasByAnimalType(int animalTypeId)
        {
            return (from r in _context.Razas
                    where r.TipoAnimalId == animalTypeId
                    select r).ToList();
        }

        public List<ReproductiveStatus> GetReproductiveStatusByAnimalType(int animalTypeId)
        {
            return (from rs in _context.ReproductiveStatuses
                    where rs.AnimalTypeId == animalTypeId
                    select rs).ToList();
        }

        public bool CreateAnimalType(string Name)
        {
            try
            {
                var exist = _context.AnimalTypes.FirstOrDefault(a => a.Nombre == Name);

                if (exist == null)
                {
                    var newAnimalType = new AnimalType()
                    {
                        Nombre = Name,
                    };
                    _context.AnimalTypes.Add(newAnimalType);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public int GetAnimalTypeId(string AnimalType)
        {
            return _context.AnimalTypes.Where(a => a.Nombre == AnimalType).Select(a => a.Id).FirstOrDefault();
        }

        public void CreateRace(Raza newRace)
        {
            try
            {
                var isExist = _context.Razas.Where(r => r.TipoAnimalId == newRace.TipoAnimalId && r.Nombre == newRace.Nombre).FirstOrDefault();

                if (isExist == null)
                {
                    _context.Razas.Add(newRace);
                    _context.SaveChanges();
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
