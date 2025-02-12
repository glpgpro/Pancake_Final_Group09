using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Pancake_Final.Domain
{
    public class ListeningHistory : BaseDomainModel
    {
        [Key]
        //primary key
        public int HistoryId { get; set; }


        //Foreign key

        public int? UserId { get; set; }

        public int Id { get; set; }

        public int? SongId   { get; set; }

        //methods
        public string? Name { get; set; }
        
        // Navigation property
        // public Song Song { get; set; } = default!;
        
        public DateTime DatePlayed { get; set; } = DateTime.UtcNow;

    }
}
