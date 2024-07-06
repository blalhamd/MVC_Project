﻿// <auto-generated />
using DotNetMvcEight.Infrastructure.Data.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotNetMvcEight.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240325231720_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DotNetMvcEight.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Film"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Racing"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Fighting"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Adventure"
                        });
                });

            modelBuilder.Entity("DotNetMvcEight.Core.Entities.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Devices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "bi bi-playstation",
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "bi bi-xbox",
                            Name = "xbox"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "bi bi-nintendo-switch",
                            Name = "Nintendo Switch"
                        },
                        new
                        {
                            Id = 4,
                            Icon = "bi bi-pc-display",
                            Name = "PC"
                        });
                });

            modelBuilder.Entity("DotNetMvcEight.Core.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Games", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 5,
                            Description = "",
                            ImagePath = "",
                            Name = "PUBGI"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "",
                            ImagePath = "",
                            Name = "Free Fire"
                        });
                });

            modelBuilder.Entity("DotNetMvcEight.Core.Entities.GameDevice", b =>
                {
                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("DeviceId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("GameDevice", (string)null);
                });

            modelBuilder.Entity("DotNetMvcEight.Core.Entities.Game", b =>
                {
                    b.HasOne("DotNetMvcEight.Core.Entities.Category", "Category")
                        .WithMany("Games")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DotNetMvcEight.Core.Entities.GameDevice", b =>
                {
                    b.HasOne("DotNetMvcEight.Core.Entities.Device", "Device")
                        .WithMany("GameDevices")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DotNetMvcEight.Core.Entities.Game", "Game")
                        .WithMany("gameDevices")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("DotNetMvcEight.Core.Entities.Category", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("DotNetMvcEight.Core.Entities.Device", b =>
                {
                    b.Navigation("GameDevices");
                });

            modelBuilder.Entity("DotNetMvcEight.Core.Entities.Game", b =>
                {
                    b.Navigation("gameDevices");
                });
#pragma warning restore 612, 618
        }
    }
}
