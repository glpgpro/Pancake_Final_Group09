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
                Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true, // Set to true, otherwise you won't be able to login
                SubStatus = "Admin"
            }

            );
        }
    }
}