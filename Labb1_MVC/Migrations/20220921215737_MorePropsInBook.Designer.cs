﻿// <auto-generated />
using System;
using Labb1_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labb1_MVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220921215737_MorePropsInBook")]
    partial class MorePropsInBook
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labb1_MVC.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<string>("PublicationYear")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "George Orwell",
                            BookName = "1984",
                            IsInStock = true,
                            PublicationYear = "1949"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "F. Scott Fitzgerald",
                            BookName = "The Great Gatsby",
                            IsInStock = true,
                            PublicationYear = "1925"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Jane Austen",
                            BookName = "Pride and Prejudice",
                            IsInStock = false,
                            PublicationYear = "1813"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "Mary Shelley",
                            BookName = "Frankenstein",
                            IsInStock = true,
                            PublicationYear = "1818"
                        },
                        new
                        {
                            BookId = 5,
                            Author = "John Steinbeck",
                            BookName = "Of Mice and Men",
                            IsInStock = false,
                            PublicationYear = "1937"
                        });
                });

            modelBuilder.Entity("Labb1_MVC.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("PersonalNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Labb1_MVC.Models.CustomerBook", b =>
                {
                    b.Property<int>("CustomerBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Borrowed")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Returned")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerBookId");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerBooks");
                });

            modelBuilder.Entity("Labb1_MVC.Models.CustomerBook", b =>
                {
                    b.HasOne("Labb1_MVC.Models.Book", "Book")
                        .WithMany("CustomerBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb1_MVC.Models.Customer", "Customer")
                        .WithMany("CustomerBooks")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
