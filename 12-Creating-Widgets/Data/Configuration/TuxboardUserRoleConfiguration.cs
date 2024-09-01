﻿using DefaultWidgets.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DefaultWidgets.Data.Configuration;

public class TuxboardUserRoleConfiguration: IEntityTypeConfiguration<TuxboardUserRole>
{
    public void Configure(EntityTypeBuilder<TuxboardUserRole> builder)
    {
        builder.ToTable(nameof(TuxboardUserRole));

        builder.HasKey(r => new { r.UserId, r.RoleId });
    }
}