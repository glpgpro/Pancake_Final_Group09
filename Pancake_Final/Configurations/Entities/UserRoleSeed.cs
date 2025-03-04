﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Pancake_Final.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {

                UserId = "3781efa7-66dc-47f0-860f-e506d04102e4",
                RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba"

            }
            );
        }
    }
}