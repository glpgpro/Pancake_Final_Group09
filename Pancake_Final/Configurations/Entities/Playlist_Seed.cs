using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pancake_Final.Domain;

namespace Pancake_Final.Configurations.Entities
{
    public class Playlist_Seed : IEntityTypeConfiguration<Playlist_Seed>
    {

        public void Configure(EntityTypeBuilder<Playlist_Seed> builder)
        {
            builder.HasData(

               new Playlist
               {

               }


           );
        }
    }
}
