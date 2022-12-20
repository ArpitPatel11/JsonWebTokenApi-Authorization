using JWTTokenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTTokenAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("Data Source=ArpitAtoZ\\SQLEXPRESS;Initial Catalog=FirstDB;Integrated Security=True;TrustServerCertificate=Yes;");
        }

        public DbSet<RegistrationUser> registrationUsers => Set<RegistrationUser>();
    }
}

