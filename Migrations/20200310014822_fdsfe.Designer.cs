﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication_Core_mvc.Data;

namespace WebApplication_Core_mvc.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20200310014822_fdsfe")]
    partial class fdsfe
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication_Core_mvc.Models.ApplicationUser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("id");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("WebApplication_Core_mvc.Models.Class1", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Class1s");
                });

            modelBuilder.Entity("WebApplication_Core_mvc.Models.Class2", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Class2s");
                });

            modelBuilder.Entity("WebApplication_Core_mvc.Models.Creation", b =>
                {
                    b.Property<int>("CreationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreationAddLike")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CreationDelete")
                        .HasColumnType("bit");

                    b.Property<string>("CreationIpAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreationLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreationPhoto750")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreationPhotoBis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreationPhotoReal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreationSex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreationTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<bool>("CreationVisible")
                        .HasColumnType("bit");

                    b.Property<string>("Creationtag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsrId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CreationId");

                    b.ToTable("Creations");
                });

            modelBuilder.Entity("WebApplication_Core_mvc.Models.CreationLike", b =>
                {
                    b.Property<int>("CreationLikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationLikeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreationLikeIpAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Userid")
                        .HasColumnType("int");

                    b.HasKey("CreationLikeId");

                    b.HasIndex("CreationId");

                    b.HasIndex("Userid");

                    b.ToTable("CreationLikes");
                });

            modelBuilder.Entity("WebApplication_Core_mvc.Models.ViewModel1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDisplayable")
                        .HasColumnType("bit");

                    b.Property<int>("MyValue")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ViewModel1");
                });

            modelBuilder.Entity("WebApplication_Core_mvc.Models.CreationLike", b =>
                {
                    b.HasOne("WebApplication_Core_mvc.Models.Creation", "ParentCreation")
                        .WithMany("CreationLikes")
                        .HasForeignKey("CreationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication_Core_mvc.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("Userid");
                });
#pragma warning restore 612, 618
        }
    }
}
