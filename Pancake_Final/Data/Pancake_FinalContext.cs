using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pancake_Final.Configurations.Entities;
using Pancake_Final.Data;

namespace Pancake_Final.Data
{
    public class Pancake_FinalContext(DbContextOptions<Pancake_FinalContext> options) : IdentityDbContext<Pancake_FinalUser>(options)
    {

        public DbSet<Pancake_Final.Domain.Song> Song { get; set; } = default!;








        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Song_Seed());
        }
    }
}
