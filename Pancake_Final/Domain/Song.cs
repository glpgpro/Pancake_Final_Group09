namespace Pancake_Final.Domain
{
    public class Song: BaseDomainModel

    {
        public string? Name { get; set; }

        public int AlbumID  { get; set; }

        public int GenID    { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
