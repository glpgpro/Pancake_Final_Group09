using System.ComponentModel.DataAnnotations;

namespace Pancake_Final.Domain
{
    public class Album : BaseDomainModel
    {
        //Primary Key

        [Key]
        public int AlbumID { get; set; }

        //Foreign Keys
        public int ArtistID { get; set; }

        public int GenID { get; set; }

        //Methods
        public string? Name { get; set; }

        public byte AlbumImage { get; set; }



    }
}
