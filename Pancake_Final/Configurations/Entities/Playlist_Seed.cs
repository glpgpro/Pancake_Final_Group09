using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pancake_Final.Domain;

namespace Pancake_Final.Configurations.Entities
{
    public class Playlist_Seed : IEntityTypeConfiguration<Playlist>
    {

        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.HasData(

               new Playlist
               {



               }


           );
        }
    }
}
