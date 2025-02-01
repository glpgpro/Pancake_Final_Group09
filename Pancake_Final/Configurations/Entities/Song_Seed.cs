

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pancake_Final.Domain;
using System;
using System.IO;
using System.Linq;
using TagLib;

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
            string rootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            string audioFolder = Path.Combine(rootPath, "music"); // Assuming files are in wwwroot/music
            string[] files = Directory.GetFiles(audioFolder, "*.mp3"); // Get all MP3 files

            List<Song> Songs = new List<Song>();

            for (int i = 0; i < files.Length; i++)
            {
                string relativePath = Path.GetRelativePath(rootPath, files[i]); // Calculate the relative path

                // Use TagLib to fetch duration
                var tfile = TagLib.File.Create(files[i]);
                TimeSpan duration = tfile.Properties.Duration; // Fetch the duration as TimeSpan

                Song song = new Song()
                {
                    SongId = i + 1, // Auto-increment SongId
                    Name = Path.GetFileNameWithoutExtension(files[i]), // File name without extension
                    FilePath = $"/{relativePath.Replace("\\", "/")}", // Web-compatible relative path
                    Duration = duration, // Use fetched duration
                    LikedS = "NotLiked", // Default value
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "Seeder",
                    UpdateBy = "Seeder",
                    ArtistId = 1, // Placeholder
                    GenID = 1 // Placeholder
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