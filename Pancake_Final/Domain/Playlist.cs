using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Pancake_Final.Data;

namespace Pancake_Final.Domain
{
    public class Playlist: BaseDomainModel
    {

        //Primary Key
        [Key]
        public int PlaylistID { get; set; }

        //Foreign Keys

        public int? UserId { get; set; }

        //Methods
        public string? PlaylistName { get; set; }
        
        // public string? CoverImagePath { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();


    }
}
