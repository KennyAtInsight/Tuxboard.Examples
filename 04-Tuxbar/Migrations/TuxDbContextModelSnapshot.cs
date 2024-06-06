﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tuxboard.Core.Data.Context;

#nullable disable

namespace _04Tuxbar.Migrations
{
    [DbContext(typeof(TuxDbContext))]
    partial class TuxDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.Dashboard", b =>
                {
                    b.Property<string>("DashboardId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasDefaultValueSql("(newid())");

                    b.Property<int>("SelectedTab")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.HasKey("DashboardId");

                    b.ToTable("Dashboard", "dbo");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.DashboardDefault", b =>
                {
                    b.Property<string>("DefaultId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("LayoutId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<int?>("PlanId")
                        .HasColumnType("int");

                    b.HasKey("DefaultId");

                    b.HasIndex("LayoutId");

                    b.HasIndex("PlanId");

                    b.ToTable("DashboardDefault", "dbo");

                    b.HasData(
                        new
                        {
                            DefaultId = "0D96A18E-90B8-4A9F-9DF1-126653D68FE6",
                            LayoutId = "5267DA05-AFE4-4753-9CEE-D5D32C2B068E"
                        });
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.DashboardDefaultWidget", b =>
                {
                    b.Property<string>("DefaultWidgetId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasDefaultValueSql("(newid())");

                    b.Property<int>("ColumnIndex")
                        .HasColumnType("int");

                    b.Property<string>("DashboardDefaultId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LayoutRowId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("WidgetId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<int>("WidgetIndex")
                        .HasColumnType("int");

                    b.HasKey("DefaultWidgetId");

                    b.HasIndex("DashboardDefaultId");

                    b.HasIndex("LayoutRowId");

                    b.HasIndex("WidgetId");

                    b.ToTable("DashboardDefaultWidget", "dbo");

                    b.HasData(
                        new
                        {
                            DefaultWidgetId = "D21E94CF-86A9-4058-BB72-F269728AC8AD",
                            ColumnIndex = 0,
                            DashboardDefaultId = "0D96A18E-90B8-4A9F-9DF1-126653D68FE6",
                            LayoutRowId = "D58AFCD2-2007-4FD0-87A9-93C85C667F3F",
                            WidgetId = "C9A9DB53-14CA-4551-87E7-F9656F39A396",
                            WidgetIndex = 0
                        });
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.DashboardTab", b =>
                {
                    b.Property<string>("TabId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("DashboardId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<int>("TabIndex")
                        .HasColumnType("int");

                    b.Property<string>("TabTitle")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("TabId");

                    b.HasIndex("DashboardId");

                    b.ToTable("DashboardTab", "dbo");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.Layout", b =>
                {
                    b.Property<string>("LayoutId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasDefaultValueSql("(newid())");

                    b.Property<int>("LayoutIndex")
                        .HasColumnType("int");

                    b.Property<string>("TabId")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.HasKey("LayoutId");

                    b.HasIndex("TabId");

                    b.ToTable("Layout", "dbo");

                    b.HasData(
                        new
                        {
                            LayoutId = "5267DA05-AFE4-4753-9CEE-D5D32C2B068E",
                            LayoutIndex = 1
                        });
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.LayoutRow", b =>
                {
                    b.Property<string>("LayoutRowId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("LayoutId")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LayoutTypeId")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<int>("RowIndex")
                        .HasColumnType("int");

                    b.HasKey("LayoutRowId");

                    b.HasIndex("LayoutId");

                    b.HasIndex("LayoutTypeId");

                    b.ToTable("LayoutRow", "dbo");

                    b.HasData(
                        new
                        {
                            LayoutRowId = "D58AFCD2-2007-4FD0-87A9-93C85C667F3F",
                            LayoutId = "5267DA05-AFE4-4753-9CEE-D5D32C2B068E",
                            LayoutTypeId = "4",
                            RowIndex = 0
                        });
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.LayoutType", b =>
                {
                    b.Property<string>("LayoutTypeId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Layout")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("LayoutTypeId");

                    b.ToTable("LayoutType", "dbo");

                    b.HasData(
                        new
                        {
                            LayoutTypeId = "1",
                            Layout = "col-4/col-4/col-4",
                            Title = "Three Columns, Equal"
                        },
                        new
                        {
                            LayoutTypeId = "2",
                            Layout = "col-3/col-6/col-3",
                            Title = "Three Columns, 50% Middle"
                        },
                        new
                        {
                            LayoutTypeId = "3",
                            Layout = "col-3/col-3/col-3/col-3",
                            Title = "Four Columns, 25%"
                        },
                        new
                        {
                            LayoutTypeId = "4",
                            Layout = "col-6/col-6",
                            Title = "Two Columns, 50%"
                        });
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.Plan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanId"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("PlanId");

                    b.ToTable("Plan", "dbo");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.Widget", b =>
                {
                    b.Property<string>("WidgetId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasDefaultValueSql("(newid())");

                    b.Property<bool>("CanDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("Moveable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Permission")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<bool>("UseSettings")
                        .HasColumnType("bit");

                    b.Property<bool>("UseTemplate")
                        .HasColumnType("bit");

                    b.HasKey("WidgetId");

                    b.ToTable("Widget", "dbo");

                    b.HasData(
                        new
                        {
                            WidgetId = "1885170C-7C48-4557-ABC7-BC06D3FC51EE",
                            CanDelete = false,
                            Description = "Display General Information",
                            GroupName = "",
                            ImageUrl = "",
                            Moveable = false,
                            Name = "generalinfo",
                            Permission = 0,
                            Title = "General Info",
                            UseSettings = false,
                            UseTemplate = false
                        },
                        new
                        {
                            WidgetId = "C9A9DB53-14CA-4551-87E7-F9656F39A396",
                            CanDelete = true,
                            Description = "A Simple Hello World Widget",
                            GroupName = "",
                            ImageUrl = "",
                            Moveable = true,
                            Name = "helloworld",
                            Permission = 0,
                            Title = "Hello World",
                            UseSettings = true,
                            UseTemplate = true
                        },
                        new
                        {
                            WidgetId = "EE84443B-7EE7-4754-BB3C-313CC0DA6039",
                            CanDelete = true,
                            Description = "Demonstration of data table",
                            GroupName = "",
                            ImageUrl = "",
                            Moveable = true,
                            Name = "table",
                            Permission = 0,
                            Title = "Sample Table",
                            UseSettings = true,
                            UseTemplate = true
                        });
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.WidgetDefault", b =>
                {
                    b.Property<string>("WidgetDefaultId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("DefaultValue")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("SettingIndex")
                        .HasColumnType("int");

                    b.Property<string>("SettingName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("SettingTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<short>("SettingType")
                        .HasColumnType("smallint");

                    b.Property<string>("WidgetId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.HasKey("WidgetDefaultId");

                    b.HasIndex("WidgetId");

                    b.ToTable("WidgetDefault", "dbo");

                    b.HasData(
                        new
                        {
                            WidgetDefaultId = "046F4AA8-5E45-4C86-B2F8-CBF3E42647E7",
                            DefaultValue = "Sample Table",
                            SettingIndex = 1,
                            SettingName = "widgettitle",
                            SettingTitle = "Title",
                            SettingType = (short)0,
                            WidgetId = "EE84443B-7EE7-4754-BB3C-313CC0DA6039"
                        },
                        new
                        {
                            WidgetDefaultId = "5C85537A-1319-48ED-A475-83D3DC3E7A8D",
                            DefaultValue = "Projects",
                            SettingIndex = 1,
                            SettingName = "widgettitle",
                            SettingTitle = "Title",
                            SettingType = (short)0,
                            WidgetId = "C9A9DB53-14CA-4551-87E7-F9656F39A396"
                        });
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.WidgetDefaultOption", b =>
                {
                    b.Property<string>("WidgetOptionId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasDefaultValueSql("(newid())");

                    b.Property<int>("SettingIndex")
                        .HasColumnType("int");

                    b.Property<string>("SettingLabel")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("SettingValue")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("WidgetDefaultId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.HasKey("WidgetOptionId")
                        .HasName("PK_WidgetSettingOption");

                    b.HasIndex("WidgetDefaultId");

                    b.ToTable("WidgetDefaultOption", "dbo");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.WidgetPlacement", b =>
                {
                    b.Property<string>("WidgetPlacementId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasDefaultValueSql("(newid())");

                    b.Property<bool>("Collapsed")
                        .HasColumnType("bit");

                    b.Property<int>("ColumnIndex")
                        .HasColumnType("int");

                    b.Property<string>("LayoutRowId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<bool>("UseSettings")
                        .HasColumnType("bit");

                    b.Property<bool>("UseTemplate")
                        .HasColumnType("bit");

                    b.Property<string>("WidgetId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<int>("WidgetIndex")
                        .HasColumnType("int");

                    b.HasKey("WidgetPlacementId");

                    b.HasIndex("LayoutRowId");

                    b.HasIndex("WidgetId");

                    b.ToTable("WidgetPlacement", "dbo");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.WidgetPlan", b =>
                {
                    b.Property<string>("WidgetId")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.HasKey("WidgetId", "PlanId");

                    b.HasIndex("PlanId");

                    b.ToTable("WidgetPlan", "dbo");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.WidgetSetting", b =>
                {
                    b.Property<string>("WidgetSettingId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Value")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("WidgetDefaultId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("WidgetPlacementId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.HasKey("WidgetSettingId");

                    b.HasIndex("WidgetDefaultId");

                    b.HasIndex("WidgetPlacementId");

                    b.ToTable("WidgetSetting", "dbo");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.DashboardDefault", b =>
                {
                    b.HasOne("Tuxboard.Core.Domain.Entities.Layout", "Layout")
                        .WithMany("DashboardDefaults")
                        .HasForeignKey("LayoutId")
                        .IsRequired()
                        .HasConstraintName("FK_DashboardDefault_Layout");

                    b.HasOne("Tuxboard.Core.Domain.Entities.Plan", "Plan")
                        .WithMany("DashboardDefaults")
                        .HasForeignKey("PlanId")
                        .HasConstraintName("FK_DashboardDefault_Plan");

                    b.Navigation("Layout");

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.DashboardDefaultWidget", b =>
                {
                    b.HasOne("Tuxboard.Core.Domain.Entities.DashboardDefault", "DashboardDefault")
                        .WithMany("DashboardDefaultWidgets")
                        .HasForeignKey("DashboardDefaultId")
                        .IsRequired()
                        .HasConstraintName("FK_DashboardDefaultWidget_DashboardDefault");

                    b.HasOne("Tuxboard.Core.Domain.Entities.LayoutRow", "LayoutRow")
                        .WithMany("DashboardDefaultWidgets")
                        .HasForeignKey("LayoutRowId")
                        .IsRequired()
                        .HasConstraintName("FK_DashboardDefaultWidget_LayoutRow");

                    b.HasOne("Tuxboard.Core.Domain.Entities.Widget", "Widget")
                        .WithMany("DashboardDefaultWidgets")
                        .HasForeignKey("WidgetId")
                        .IsRequired()
                        .HasConstraintName("FK_DashboardDefaultWidget_Widget");

                    b.Navigation("DashboardDefault");

                    b.Navigation("LayoutRow");

                    b.Navigation("Widget");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.DashboardTab", b =>
                {
                    b.HasOne("Tuxboard.Core.Domain.Entities.Dashboard", "Dashboard")
                        .WithMany("Tabs")
                        .HasForeignKey("DashboardId")
                        .IsRequired()
                        .HasConstraintName("FK_DashboardTab_Dashboard");

                    b.Navigation("Dashboard");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.Layout", b =>
                {
                    b.HasOne("Tuxboard.Core.Domain.Entities.DashboardTab", "Tab")
                        .WithMany("Layouts")
                        .HasForeignKey("TabId")
                        .HasConstraintName("FK_DashboardLayout_DashboardTab");

                    b.Navigation("Tab");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.LayoutRow", b =>
                {
                    b.HasOne("Tuxboard.Core.Domain.Entities.Layout", "Layout")
                        .WithMany("LayoutRows")
                        .HasForeignKey("LayoutId")
                        .HasConstraintName("FK_LayoutRow_Layout");

                    b.HasOne("Tuxboard.Core.Domain.Entities.LayoutType", "LayoutType")
                        .WithMany("LayoutRows")
                        .HasForeignKey("LayoutTypeId")
                        .HasConstraintName("FK_LayoutRow_LayoutType");

                    b.Navigation("Layout");

                    b.Navigation("LayoutType");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.WidgetDefault", b =>
                {
                    b.HasOne("Tuxboard.Core.Domain.Entities.Widget", "Widget")
                        .WithMany("WidgetDefaults")
                        .HasForeignKey("WidgetId")
                        .IsRequired()
                        .HasConstraintName("FK_WidgetDefault_Widget");

                    b.Navigation("Widget");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.WidgetDefaultOption", b =>
                {
                    b.HasOne("Tuxboard.Core.Domain.Entities.WidgetDefault", "WidgetDefault")
                        .WithMany("WidgetDefaultOptions")
                        .HasForeignKey("WidgetDefaultId")
                        .IsRequired()
                        .HasConstraintName("FK_WidgetDefaultOption_WidgetDefault");

                    b.Navigation("WidgetDefault");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.WidgetPlacement", b =>
                {
                    b.HasOne("Tuxboard.Core.Domain.Entities.LayoutRow", "LayoutRow")
                        .WithMany("WidgetPlacements")
                        .HasForeignKey("LayoutRowId")
                        .IsRequired()
                        .HasConstraintName("FK_WidgetPlacement_LayoutRow1");

                    b.HasOne("Tuxboard.Core.Domain.Entities.Widget", "Widget")
                        .WithMany("WidgetPlacements")
                        .HasForeignKey("WidgetId")
                        .IsRequired()
                        .HasConstraintName("FK_WidgetPlacement_Widget1");

                    b.Navigation("LayoutRow");

                    b.Navigation("Widget");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.WidgetPlan", b =>
                {
                    b.HasOne("Tuxboard.Core.Domain.Entities.Plan", "Plan")
                        .WithMany("WidgetPlans")
                        .HasForeignKey("PlanId")
                        .IsRequired()
                        .HasConstraintName("FK_WidgetPlan_Plan");

                    b.HasOne("Tuxboard.Core.Domain.Entities.Widget", "Widget")
                        .WithMany("WidgetPlans")
                        .HasForeignKey("WidgetId")
                        .IsRequired()
                        .HasConstraintName("FK_WidgetPlan_Widget");

                    b.Navigation("Plan");

                    b.Navigation("Widget");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.WidgetSetting", b =>
                {
                    b.HasOne("Tuxboard.Core.Domain.Entities.WidgetDefault", "WidgetDefault")
                        .WithMany("WidgetSettings")
                        .HasForeignKey("WidgetDefaultId")
                        .IsRequired()
                        .HasConstraintName("FK_WidgetSetting_WidgetDefault");

                    b.HasOne("Tuxboard.Core.Domain.Entities.WidgetPlacement", "WidgetPlacement")
                        .WithMany("WidgetSettings")
                        .HasForeignKey("WidgetPlacementId")
                        .IsRequired()
                        .HasConstraintName("FK_WidgetSetting_WidgetPlacement");

                    b.Navigation("WidgetDefault");

                    b.Navigation("WidgetPlacement");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.Dashboard", b =>
                {
                    b.Navigation("Tabs");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.DashboardDefault", b =>
                {
                    b.Navigation("DashboardDefaultWidgets");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.DashboardTab", b =>
                {
                    b.Navigation("Layouts");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.Layout", b =>
                {
                    b.Navigation("DashboardDefaults");

                    b.Navigation("LayoutRows");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.LayoutRow", b =>
                {
                    b.Navigation("DashboardDefaultWidgets");

                    b.Navigation("WidgetPlacements");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.LayoutType", b =>
                {
                    b.Navigation("LayoutRows");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.Plan", b =>
                {
                    b.Navigation("DashboardDefaults");

                    b.Navigation("WidgetPlans");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.Widget", b =>
                {
                    b.Navigation("DashboardDefaultWidgets");

                    b.Navigation("WidgetDefaults");

                    b.Navigation("WidgetPlacements");

                    b.Navigation("WidgetPlans");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.WidgetDefault", b =>
                {
                    b.Navigation("WidgetDefaultOptions");

                    b.Navigation("WidgetSettings");
                });

            modelBuilder.Entity("Tuxboard.Core.Domain.Entities.WidgetPlacement", b =>
                {
                    b.Navigation("WidgetSettings");
                });
#pragma warning restore 612, 618
        }
    }
}
