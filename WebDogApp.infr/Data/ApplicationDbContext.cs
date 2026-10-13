using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using WebDogApp.infr.Data.Domain;

namespace WebDogApp.Data.infr.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated ();

        }
        public DbSet <Dog>Dogs {  get; set; }

        public DbSet<Breed> Breeds { get; set; }

    }
}
