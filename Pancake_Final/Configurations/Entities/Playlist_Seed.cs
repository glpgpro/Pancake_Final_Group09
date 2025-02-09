using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pancake_Final.Domain;

namespace Pancake_Final.Configurations.Entities
{
    public class Playlist_Seed : IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            // Seed the Playlist
            builder.HasData(
                new Playlist
                {
                    PlaylistId = 1,
                    UserId = null,
                    GenreID = 1,
                    PlaylistName = "Made for You",
                    CoverImagePath = "/images/SeededPlaylistPicture.jpg",
                    NewGenreName = "Daily Recommended Playlists",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Admin",
                    UpdateBy = "Admin",
                    Songs = new List<Song>
                    {
                        new Song
                        {
                            SongId = 1,
                            PlaylistId = 1, // Associate with PlaylistId 1
                            ArtistId = 1,
                            Name = "Imagine Dragons - Believer",
                            FilePath = "/music/Imagine Dragons - Believer.mp3",
                            Duration = TimeSpan.FromMinutes(3),
                            LikedS = "NotLiked",
                            DateAdded = DateTime.Now,
                            DateCreated = DateTime.Now,
                            DateUpdated = DateTime.Now
                        },
                        new Song
                        {
                            SongId = 2,
                            PlaylistId = 1, // Associate with PlaylistId 1
                            ArtistId = 2,
                            Name = "Jaden - GOKU",
                            FilePath = "/music/Jaden - GOKU.mp3",
                            Duration = TimeSpan.FromMinutes(4),
                            LikedS = "NotLiked",
                            DateAdded = DateTime.Now,
                            DateCreated = DateTime.Now,
                            DateUpdated = DateTime.Now
                        },
                        new Song
                        {
                            SongId = 3,
                            PlaylistId = 1, // Associate with PlaylistId 1
                            ArtistId = 3,
                            Name = "Khai Dreams - Sunkissed",
                            FilePath = "/music/khai dreams - sunkissed.mp3",
                            Duration = TimeSpan.FromMinutes(3),
                            LikedS = "NotLiked",
                            DateAdded = DateTime.Now,
                            DateCreated = DateTime.Now,
                            DateUpdated = DateTime.Now
                        },
                        new Song
                        {
                            SongId = 4,
                            PlaylistId = 1, // Associate with PlaylistId 1
                            ArtistId = 4,
                            Name = "KUURO - What U Wanna Do",
                            FilePath = "/music/KUURO - What U Wanna Do.mp3",
                            Duration = TimeSpan.FromMinutes(5),
                            LikedS = "NotLiked",
                            DateAdded = DateTime.Now,
                            DateCreated = DateTime.Now,
                            DateUpdated = DateTime.Now

                        }
                    }
                }
            );
        }
    }
}
