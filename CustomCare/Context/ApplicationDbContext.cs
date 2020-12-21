using Microsoft.EntityFrameworkCore;
using CustomCare.Models;

namespace CustomCare.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Client> Rpa { get; set; }

    }
}
