namespace Pancake_Final.Domain
{
    public class Playlist : BaseDomainModel
    {

        //Primary Key
        public int PlaylistID { get; set; }

        //Foreign Keys

        public int UserId { get; set; }

        //Methods
        public string? PlaylistName { get; set; }

    }
}
