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
        
        [ForeignKey(nameof(user))]
        public string ASPNetUserID { get; set; } = null!; // Matches Id in IdentityUser
        public Pancake_FinalUser user { get; set; } = null!;
        
        public int PlayListID { get; set; }

        public int SubId { get; set; }  

        public int SubStatus { get; set; } = 0; //Default classifies as a free user

        //methods
        public string? Name     { get; set; }

        public string? Email { get; set; }
       


    }
}
