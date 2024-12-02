using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pancake_Final.Configurations.Entities;
using Pancake_Final.Domain;

namespace Pancake_Final.Data
{
    public class Pancake_FinalContext : DbContext
    {
        public Pancake_FinalContext (DbContextOptions<Pancake_FinalContext> options)
            : base(options)
        {
        }

        public DbSet<Pancake_Final.Domain.Song> Song { get; set; } = default!;








        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Song_Seed());
        }

    }
}
