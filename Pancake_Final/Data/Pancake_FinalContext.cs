using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pancake_Final.Configurations.Entities;
using Pancake_Final.Data;
using Pancake_Final.Domain;

namespace Pancake_Final.Data
{
    public class Pancake_FinalContext(DbContextOptions<Pancake_FinalContext> options) : IdentityDbContext<Pancake_FinalUser>(options)
    {

        public DbSet<Pancake_Final.Domain.Song> Song { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Song_Seed());
            modelBuilder.ApplyConfiguration(new UserSeed());
        }
        public DbSet<Pancake_Final.Domain.Artists> Artists { get; set; } = default!;
        public DbSet<Pancake_Final.Domain.Album> Album { get; set; } = default!;
        public DbSet<Pancake_Final.Domain.Genre> Genre { get; set; } = default!;
        public DbSet<Pancake_Final.Domain.Playlist> Playlist { get; set; } = default!;
        public DbSet<Pancake_Final.Domain.PaymentMethod> PaymentMethod { get; set; } = default!;
        public DbSet<Pancake_Final.Domain.ListeningHistory> ListeningHistory { get; set; } = default!;
        public DbSet<Pancake_Final.Domain.Subscription> Subscription { get; set; } = default!;
        public DbSet<Pancake_Final.Domain.User> User { get; set; } = default!;
    }
}
