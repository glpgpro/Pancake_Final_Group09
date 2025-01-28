

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pancake_Final.Domain;
using System;
using System.IO;
using System.Linq;

namespace Pancake_Final.Configurations.Entities
{
    public class Song_Seed : IEntityTypeConfiguration<Song>
    {
        private readonly string _folderPath;

        // Constructor to pass the folder path
        public Song_Seed(string folderPath)
        {
            _folderPath = folderPath;
        }


        public void Configure(EntityTypeBuilder<Song> builder)
        {

            List<Song> Songs = new();
            // Read MP3 files from the folder
            var files = Directory.GetFiles(_folderPath, "*.mp3");

            for (int i = 0; i < files.Length; i++)
            {
                Song song = new Song()
                {
                    SongId = i + 1, // Auto-increment SongId
                    Name = Path.GetFileNameWithoutExtension(files[i]),
                    FilePath = files[i],
                    Duration = TimeSpan.Zero, // Placeholder (update if you fetch duration)
                    LikedS = "NotLiked", // Default value
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seeder",
                    UpdateBy = "Seeder",
                    ArtistId = 1, // Placeholder, update later if needed
                    GenID = 1 // Placeholder, update later if needed
                };
                Songs.Add(song);
            }


            // Generate seed data for each file
            //var songs = files.Select((filePath, index) => new Song
            //{
            //    SongId = index + 1, // Auto-increment SongId
            //    Name = Path.GetFileNameWithoutExtension(filePath),
            //    FilePath = filePath,
            //    Duration = TimeSpan.Zero, // Placeholder (update if you fetch duration)
            //    LikedS = "NotLiked", // Default value
            //    DateCreated = DateTime.Now,
            //    DateUpdated = DateTime.Now,
            //    CreatedBy = "Seeder",
            //    UpdateBy = "Seeder",
            //    ArtistId = 1, // Placeholder, update later if needed
            //    AlbumID = 1, // Placeholder, update later if needed
            //    GenID = 1 // Placeholder, update later if needed
            //}).ToArray();

            // Add songs to the builder
            builder.HasData(Songs.ToArray());

        }
    }
}