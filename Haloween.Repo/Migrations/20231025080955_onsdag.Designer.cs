﻿// <auto-generated />
using System;
using Haloween.Repo.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Haloween.Repo.Migrations
{
    [DbContext(typeof(Dbcontext))]
    [Migration("20231025080955_onsdag")]
    partial class onsdag
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Haloween.Repo.DTO.SuperHero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Debut")
                        .HasColumnType("datetime2");

                    b.Property<string>("HeroName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Powers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RealName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("SuperHero");
                });

            modelBuilder.Entity("Haloween.Repo.DTO.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("Haloween.Repo.DTO.SuperHero", b =>
                {
                    b.HasOne("Haloween.Repo.DTO.Team", null)
                        .WithMany("SuperHeroes")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Haloween.Repo.DTO.Team", b =>
                {
                    b.Navigation("SuperHeroes");
                });
#pragma warning restore 612, 618
        }
    }
}
