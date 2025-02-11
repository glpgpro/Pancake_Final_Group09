using Microsoft.AspNetCore.Identity;

namespace Pancake_Final.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Pancake_FinalUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string SubStatus { get; set; } = "free";
        public string? AspNetUserId { get; set; }
        public string? User { get; set; }
    }
}
