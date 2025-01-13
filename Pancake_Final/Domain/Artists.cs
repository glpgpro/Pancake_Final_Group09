using System.ComponentModel.DataAnnotations;

namespace Pancake_Final.Domain
{
    public class Artists
    {

        //Primary Key
        [Key]
        public int ArtistID { get; set; }

        //Foreign Key
        public int SongId { get; set; }

        //Navigation Property

        public ICollection<Song>? Songs { get; set; }

        //Methods
        public string? Name { get; set; }

    }
}
