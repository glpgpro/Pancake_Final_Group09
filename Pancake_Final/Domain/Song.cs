using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Pancake_Final.Domain
{
    public class Song : BaseDomainModel

    {
        //Foreign Key
        public int? ArtistId { get; set; }

        public int? AlbumID { get; set; }

        public int? GenID { get; set; }
        
        public int? PlaylistId { get; set; }

        // Navigation property

        //[JsonIgnore]
        //public Artists Artists { get; set; } = null!;

        //public Album Album { get; set; } = null!;

        //public Genre Genre { get; set; } = null!;

        //Primary Key

        [Key]
        public int? SongId { get; set; }

        //Methods
        public string? Name { get; set; }

        public string? LikedS { get; set; }

        public string FilePath { get; set; } = string.Empty;

        public TimeSpan Duration { get; set; }
        public DateTime DateAdded { get; set; }
  

        //public string SongImage { get; set;}


    }
}
