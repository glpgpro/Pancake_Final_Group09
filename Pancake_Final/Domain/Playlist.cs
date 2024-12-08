namespace Pancake_Final.Domain
{
    public class Playlist : BaseDomainModel
    {
        public int PlaylistID { get; set; }
        public string PlaylistName { get; set; } = string.Empty;
        public List<string> Songs { get; set; } = new List<string>();

    }
}
