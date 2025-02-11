using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pancake_Final.Configurations.Entities;
using Pancake_Final.Domain;

namespace Pancake_Final.Data
{
    public class Pancake_FinalContext : IdentityDbContext<Pancake_FinalUser>
    {
        public Pancake_FinalContext(DbContextOptions<Pancake_FinalContext> options)
            : base(options)
        {
        }

        public DbSet<Song> Song { get; set; }
        public DbSet<Artists> Artists { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Playlist> Playlist { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<ListeningHistory> ListeningHistory { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //// Configure Playlist-Song relationship
            modelBuilder.Entity<Playlist>()
                .HasMany(p => p.Songs)        // A playlist can have many songs
                .WithOne(s => s.Playlist)    // Each song belongs to one playlist
                .HasForeignKey(s => s.PlaylistId) // Foreign key in Song
                .OnDelete(DeleteBehavior.Restrict); // Optional: Cascade delete
            modelBuilder.Entity<Playlist>()
                .HasOne(p => p.Genre)
                .WithMany()
                .HasForeignKey(p => p.GenreID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent deletion of Genres.

            // Apply additional configurations
            modelBuilder.ApplyConfiguration(new Song_Seed(GetFolderPath()));
            modelBuilder.ApplyConfiguration(new Genre_Seed());
            modelBuilder.ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserRoleSeed());

        }

        // Helper method to get folder path for seed data
        private string GetFolderPath()
        {
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "music");

            // Ensure the folder exists
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            return folderPath;
        }
    }
}