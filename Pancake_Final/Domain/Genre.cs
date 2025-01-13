using System.ComponentModel.DataAnnotations;

namespace Pancake_Final.Domain
{
    public class Genre : BaseDomainModel
    {

        //Primary Key
        [Key]
        public string? GenreID { get; set; }

        //Methods

        public string? GenreName { get; set; }

    }
}
