﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pancake_Final.Domain;

namespace Pancake_Final.Configurations.Entities
{
    public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                 new IdentityRole
                 {
                     Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                     Name = "Administrator",
                     NormalizedName = "ADMINISTRATOR"
                 },

                 new IdentityRole
                 {
                     Id = "190871DC-1FE6-4346-980D-EB4D895E8E48",
                     Name = "User",
                     NormalizedName = "USER"
                 }
             );
        }
    }
}

