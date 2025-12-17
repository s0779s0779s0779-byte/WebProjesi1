using Microsoft.EntityFrameworkCore;
using WebProjesi1.Models;

namespace WebProjesi1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }
    }
}
