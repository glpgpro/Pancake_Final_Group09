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

        public int UserId       { get; set; }

        public string? SongId   { get; set; }

        //methods
        public string? Name { get; set; }

    }
}
