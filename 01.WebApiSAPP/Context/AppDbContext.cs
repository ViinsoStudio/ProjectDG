using Microsoft.EntityFrameworkCore;
using WebApiSAPP.Models;

namespace WebApiSAPP.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
