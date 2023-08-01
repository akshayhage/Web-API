﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web_API.DataAccess;

#nullable disable

namespace Web_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230801110200_DateAdded")]
    partial class DateAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasKey("Id");

                    b.ToTable("villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTime(2023, 8, 1, 16, 32, 0, 139, DateTimeKind.Local).AddTicks(2579),
                            Name = "Royal Home"
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTime(2023, 8, 1, 16, 32, 0, 139, DateTimeKind.Local).AddTicks(2597),
                            Name = "Shree Home"
                        },
                        new
                        {
                            Id = 3,
                            CreatedTime = new DateTime(2023, 8, 1, 16, 32, 0, 139, DateTimeKind.Local).AddTicks(2601),
                            Name = "Sprash Home"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
