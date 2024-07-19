using DataAccessSAPP.Context;
using DataAccessSAPP.Entities;

namespace DataAccessSAPP.Queries
{
    public class UsersQueries
    {
        private readonly AppDbContext _context;

        public UsersQueries(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Se registra un nuevo usuario de la App
        /// </summary>
        /// <param name="user">Corresponde a los datos del usuario registrado</param>
        /// <returns>True si el registro de hace con éxito o false se no es exitoso</returns>
        public bool UserRegister(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }   
        }

        public List<User> GetRegisteredUsers()
        {
            var users = (from user in _context.Users
                        select user).ToList();

            return users;
        }

        public List<Country> GetCountries()
        {
            return _context.Countries.ToList();
        }

        public List<DepStaPro> GetDepStaProsByCountry(int countryId)
        {
            return _context.DepStaPros.Where(dsp => dsp.CountryId == countryId).ToList();
        }

        public List<CitMun> GetCitMunsByDepStaPro(int DepStaProId)
        {
            return _context.CitMuns.Where(cm => cm.DepStaProId == DepStaProId).ToList();
        }
    }
}
