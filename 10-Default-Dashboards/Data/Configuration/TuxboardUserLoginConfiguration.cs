﻿using DefaultDashboards.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DefaultDashboards.Data.Configuration;

public class TuxboardUserLoginConfiguration: IEntityTypeConfiguration<TuxboardUserLogin>
{
    public void Configure(EntityTypeBuilder<TuxboardUserLogin> builder)
    {
        builder.ToTable(nameof(TuxboardUserLogin));
        builder.HasKey(l => new { l.LoginProvider, l.ProviderKey });
    }
}