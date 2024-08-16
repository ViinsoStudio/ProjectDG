using DataAccessSAPP.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessSAPP.Context
{
    public class AppDbContext: DbContext
    {
        public static string ConnectionString;

        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DepStaPro> DepStaPros {  get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<CitMun> CitMuns { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString,
                    b => b.MigrationsAssembly("DataAccessSAPP"));
            }
        }
    }
}
