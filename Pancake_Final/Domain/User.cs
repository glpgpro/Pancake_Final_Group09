using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Pancake_Final.Data;

namespace Pancake_Final.Domain
{
    public class User : BaseDomainModel
    {
        //primary key
        
        [Key]
        public int UserId { get; set; }
        // Foreign key

        public int PlayListID { get; set; }

        public int SubId { get; set; }

        public string SubStatus { get; set; } = "free";//Default classifies as a free user

        //methods
        public string? Name { get; set; }

        public string? Email { get; set; }

    }
}
