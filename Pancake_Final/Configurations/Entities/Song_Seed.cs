using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pancake_Final.Domain;
namespace Pancake_Final.Configurations.Entities
{
    public class Song_Seed : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasData(

                new Song
                {
                    SongId = 1,
                    ArtistId = 1,
                    AlbumID = 1,
                    GenID = 1,
                    Name = "Don Toliver - No Pole",
                    LikedS = "Liked",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdateBy = "System"
                }

            );
        }
    }
}
