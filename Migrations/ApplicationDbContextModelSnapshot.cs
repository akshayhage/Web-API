﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web_API.DataAccess;

#nullable disable

namespace Web_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.6.23329.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Web_API.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTime(2023, 8, 1, 17, 11, 27, 678, DateTimeKind.Local).AddTicks(5294),
                            Name = "Royal Home",
                            Occupancy = 10,
                            Sqft = 1200
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTime(2023, 8, 1, 17, 11, 27, 678, DateTimeKind.Local).AddTicks(5311),
                            Name = "Shree Home",
                            Occupancy = 10,
                            Sqft = 1200
                        },
                        new
                        {
                            Id = 3,
                            CreatedTime = new DateTime(2023, 8, 1, 17, 11, 27, 678, DateTimeKind.Local).AddTicks(5313),
                            Name = "Sprash Home",
                            Occupancy = 10,
                            Sqft = 1200
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
