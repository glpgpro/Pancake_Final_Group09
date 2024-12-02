namespace Pancake_Final.Domain
{
    public class Album : BaseDomainModel
    {
        public string? Name { get; set; }

        public int ArtistID { get; set; }

        public int GenID { get; set; }
    }
}
