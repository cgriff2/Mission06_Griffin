﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_Griffin.Models;

#nullable disable

namespace Mission06_Griffin.Migrations
{
    [DbContext(typeof(JoelHiltonMovieCollectionContext))]
    [Migration("20240223235928_Migrate")]
    partial class Migrate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Mission06_Griffin.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("Mission06_Griffin.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CopiedToPlex")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Mission06_Griffin.Models.Movie", b =>
                {
                    b.HasOne("Mission06_Griffin.Models.Category", "CategoryName")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("CategoryName");
                });
#pragma warning restore 612, 618
        }
    }
}
