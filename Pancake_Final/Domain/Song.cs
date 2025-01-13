namespace Pancake_Final.Domain
{
    public class Song : BaseDomainModel

    {
        //Foreign Key
        public int ArtistId { get; set; }
        // Navigation property

        public Artists Artists { get; set; }

        //Primary Key
        public int? SongId { get; set; }

        //Methods
        public string? Name { get; set; }

        public string? LikedS { get; set; } 

        public  byte SongImage { get; set;}


    }
}
