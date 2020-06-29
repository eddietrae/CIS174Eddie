﻿// <auto-generated />
using CIS174Eddie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CIS174Eddie.Migrations.Country
{
    [DbContext(typeof(CountryContext))]
    [Migration("20200628234409_Games")]
    partial class Games
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CIS174Eddie.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = "indoor",
                            Name = "Indoor"
                        },
                        new
                        {
                            CategoryID = "outdoor",
                            Name = "Outdoor"
                        });
                });

            modelBuilder.Entity("CIS174Eddie.Models.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FlagImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("GameID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CIS174Eddie.Models.Game", b =>
                {
                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameID");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameID = "para",
                            Name = "Paralympics"
                        },
                        new
                        {
                            GameID = "so",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            GameID = "wo",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameID = "yo",
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("CIS174Eddie.Models.Country", b =>
                {
                    b.HasOne("CIS174Eddie.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.HasOne("CIS174Eddie.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID");
                });
#pragma warning restore 612, 618
        }
    }
}
