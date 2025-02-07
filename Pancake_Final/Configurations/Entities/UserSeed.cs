using Pancake_Final.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pancake_Final.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<Pancake_FinalUser>
    {
        public void Configure(EntityTypeBuilder<Pancake_FinalUser> builder)
        {
            var hasher = new PasswordHasher<Pancake_FinalUser>();
            builder.HasData(
            new Pancake_FinalUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            
            new Pancake_FinalUser()
            {
                
                Id = "30f01c03-6b69-4bf0-95ba-72ac6e7e4773",
                Email = "ghostreaper740@gmail.com",
                NormalizedEmail = "GHOSTREAPER740@GMAIL.COM",
                FirstName = "Test",
                LastName = "user",
                UserName = "Amsul Shamry",
                NormalizedUserName = "GHOSTREAPER740@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "testpassword123"),
                EmailConfirmed = true 
                
            }
            );
        }
    }
}