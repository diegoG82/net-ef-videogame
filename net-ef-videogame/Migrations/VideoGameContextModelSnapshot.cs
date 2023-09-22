﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using net_ef_videogame.Database;

#nullable disable

namespace net_ef_videogame.Migrations
{
    [DbContext(typeof(VideoGameContext))]
    partial class VideoGameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("net_ef_videogame.Models.SoftwareHouse", b =>
                {
                    b.Property<long>("SoftwareHouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SoftwareHouseId"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SoftwareHouseId");

                    b.ToTable("SoftwareHouses");
                });

            modelBuilder.Entity("net_ef_videogame.Models.Videogame", b =>
                {
                    b.Property<long>("VideogameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("VideogameId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Overview")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("SoftwareHouseId")
                        .HasColumnType("bigint");

                    b.HasKey("VideogameId");

                    b.HasIndex("SoftwareHouseId");

                    b.ToTable("Videogames");
                });

            modelBuilder.Entity("net_ef_videogame.Models.Videogame", b =>
                {
                    b.HasOne("net_ef_videogame.Models.SoftwareHouse", "SoftwareHouse")
                        .WithMany("Videogames")
                        .HasForeignKey("SoftwareHouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SoftwareHouse");
                });

            modelBuilder.Entity("net_ef_videogame.Models.SoftwareHouse", b =>
                {
                    b.Navigation("Videogames");
                });
#pragma warning restore 612, 618
        }
    }
}
