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
    }
}
