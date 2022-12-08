﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.Data;

#nullable disable

namespace webapi.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    partial class ProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webapi.Models.Entities.book", b =>
                {
                    b.Property<Guid>("Book_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("available")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bk_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bk_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pub_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Book_ID");

                    b.ToTable("book");
                });

            modelBuilder.Entity("webapi.Models.Entities.borrowing", b =>
                {
                    b.Property<Guid>("Borrowing_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("book_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("date_borrowed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("date_return")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("librarian_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("student_ID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Borrowing_ID");

                    b.HasIndex("book_ID");

                    b.HasIndex("librarian_ID");

                    b.HasIndex("student_ID");

                    b.ToTable("borrowing");
                });

            modelBuilder.Entity("webapi.Models.Entities.librarian", b =>
                {
                    b.Property<Guid>("Librarian_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("joining_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("officer_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Librarian_ID");

                    b.ToTable("librarian");
                });

            modelBuilder.Entity("webapi.Models.Entities.student", b =>
                {
                    b.Property<Guid>("Student_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("contact_add")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("student_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("student_pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Student_ID");

                    b.ToTable("student");
                });

            modelBuilder.Entity("webapi.Models.Entities.borrowing", b =>
                {
                    b.HasOne("webapi.Models.Entities.book", null)
                        .WithMany()
                        .HasForeignKey("book_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi.Models.Entities.librarian", null)
                        .WithMany()
                        .HasForeignKey("librarian_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi.Models.Entities.student", null)
                        .WithMany()
                        .HasForeignKey("student_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
