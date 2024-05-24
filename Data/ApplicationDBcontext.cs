using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ApplicationDBcontext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
            optionsBuilder.UseSqlServer("server=.;database=asp8;trusted_connection=true;trustServerCertificate=true");
        }
    }
}
