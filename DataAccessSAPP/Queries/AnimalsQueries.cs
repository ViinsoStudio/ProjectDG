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

        public bool AnimalsRegister(List<Animal> animalsData)
        {
            try
            {
                _context.Animals.AddRange(animalsData);
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
    }
}
