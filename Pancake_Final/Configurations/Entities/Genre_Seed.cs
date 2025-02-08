using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pancake_Final.Domain;
using System;

namespace Pancake_Final.Configurations.Entities
{
    public class Genre_Seed : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre
                {
                    Id = 1,  // Ensuring a unique Id (from BaseDomainModel)
                    GenreID = 1,  // Primary key (if necessary)
                    GenreName = "Liked Songs",
                    DateCreated = DateTime.UtcNow,  // Setting creation date
                    DateUpdated = DateTime.UtcNow,  // Setting update date
                    CreatedBy = "System",  // Default creator
                    UpdateBy = "System"  // Default updater
                }
            );
        }
    }
}