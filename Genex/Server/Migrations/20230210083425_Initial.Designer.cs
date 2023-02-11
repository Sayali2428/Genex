﻿// <auto-generated />
using System;
using Genex.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Genex.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230210083425_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Genex.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "aperture",
                            Name = "MotorBike",
                            Url = "Motorbike"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "camera-slr",
                            Name = "Cars",
                            Url = "Car"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "calculator",
                            Name = "Mobile Phones",
                            Url = "MobilePhone"
                        });
                });

            modelBuilder.Entity("Genex.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2023, 2, 10, 14, 4, 25, 363, DateTimeKind.Local).AddTicks(4386),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Product Descripton",
                            Image = "https://bd.gaadicdn.com/processedimages/joye-bike/thunderbolt/640X309/thunderbolt6315ccda73896.jpg?tr=w-360",
                            IsDelete = false,
                            IsPublic = false,
                            Price = 280000m,
                            Title = "Galaxy Motor"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            DateCreated = new DateTime(2023, 2, 10, 14, 4, 25, 363, DateTimeKind.Local).AddTicks(4421),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Product Descripton",
                            Image = "https://img.freepik.com/free-vector/modern-blue-urban-adventure-suv-vehicle-illustration_1344-205.jpg?w=2000",
                            IsDelete = false,
                            IsPublic = false,
                            Price = 280000m,
                            Title = "Galaxy Car"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            DateCreated = new DateTime(2023, 2, 10, 14, 4, 25, 363, DateTimeKind.Local).AddTicks(4426),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Product Descripton",
                            Image = "https://m.media-amazon.com/images/I/61l9ppRIiqL._SX466_.jpg",
                            IsDelete = false,
                            IsPublic = false,
                            Price = 280000m,
                            Title = "Galaxy Phone"
                        });
                });

            modelBuilder.Entity("Genex.Shared.Product", b =>
                {
                    b.HasOne("Genex.Shared.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Genex.Shared.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
