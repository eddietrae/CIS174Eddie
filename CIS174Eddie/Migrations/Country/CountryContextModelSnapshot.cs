﻿// <auto-generated />
using CIS174Eddie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CIS174Eddie.Migrations.Country
{
    [DbContext(typeof(CountryContext))]
    partial class CountryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            CountryID = "can",
                            CategoryID = "indoor",
                            FlagImage = "flag-of-Canada.png",
                            GameID = "wo",
                            Name = "Canada"
                        },
                        new
                        {
                            CountryID = "swe",
                            CategoryID = "indoor",
                            FlagImage = "flag-of-Sweden.png",
                            GameID = "wo",
                            Name = "Sweden"
                        },
                        new
                        {
                            CountryID = "gre",
                            CategoryID = "indoor",
                            FlagImage = "flag-of-United-Kingdom.png",
                            GameID = "wo",
                            Name = "Great Britain"
                        },
                        new
                        {
                            CountryID = "jam",
                            CategoryID = "outdoor",
                            FlagImage = "flag-of-Jamaica.png",
                            GameID = "wo",
                            Name = "Jamaica"
                        },
                        new
                        {
                            CountryID = "ita",
                            CategoryID = "outdoor",
                            FlagImage = "flag-of-Italy.png",
                            GameID = "wo",
                            Name = "Italy"
                        },
                        new
                        {
                            CountryID = "jap",
                            CategoryID = "outdoor",
                            FlagImage = "flag-of-Japan.png",
                            GameID = "wo",
                            Name = "Japan"
                        },
                        new
                        {
                            CountryID = "ger",
                            CategoryID = "indoor",
                            FlagImage = "flag-of-Germany.png",
                            GameID = "so",
                            Name = "Germany"
                        },
                        new
                        {
                            CountryID = "chi",
                            CategoryID = "indoor",
                            FlagImage = "flag-of-China.png",
                            GameID = "so",
                            Name = "China"
                        },
                        new
                        {
                            CountryID = "mex",
                            CategoryID = "indoor",
                            FlagImage = "flag-of-Mexic.png",
                            GameID = "so",
                            Name = "Mexico"
                        },
                        new
                        {
                            CountryID = "bra",
                            CategoryID = "outdoor",
                            FlagImage = "flag-of-Brazil.png",
                            GameID = "so",
                            Name = "Brazil"
                        },
                        new
                        {
                            CountryID = "net",
                            CategoryID = "outdoor",
                            FlagImage = "flag-of-Netherlands.png",
                            GameID = "so",
                            Name = "Netherlands"
                        },
                        new
                        {
                            CountryID = "usa",
                            CategoryID = "outdoor",
                            FlagImage = "flag-of-United-States-of-America.png",
                            GameID = "so",
                            Name = "USA"
                        },
                        new
                        {
                            CountryID = "tha",
                            CategoryID = "indoor",
                            FlagImage = "flag-of-Thailand.png",
                            GameID = "para",
                            Name = "Thailand"
                        },
                        new
                        {
                            CountryID = "uru",
                            CategoryID = "indoor",
                            FlagImage = "flag-of-Uruguay.png",
                            GameID = "para",
                            Name = "Uruguay"
                        },
                        new
                        {
                            CountryID = "ukr",
                            CategoryID = "indoor",
                            FlagImage = "flag-of-Ukraine.png",
                            GameID = "para",
                            Name = "Ukraine"
                        },
                        new
                        {
                            CountryID = "aus",
                            CategoryID = "outdoor",
                            FlagImage = "flag-of-Austria.png",
                            GameID = "para",
                            Name = "Austria"
                        },
                        new
                        {
                            CountryID = "pak",
                            CategoryID = "outdoor",
                            FlagImage = "flag-of-Pakistan.png",
                            GameID = "para",
                            Name = "Pakistan"
                        },
                        new
                        {
                            CountryID = "zim",
                            CategoryID = "outdoor",
                            FlagImage = "flag-of-Zimbabwe.png",
                            GameID = "para",
                            Name = "Zimbabwe"
                        },
                        new
                        {
                            CountryID = "fra",
                            CategoryID = "indoor",
                            FlagImage = "flag-of-France.png",
                            GameID = "yo",
                            Name = "France"
                        },
                        new
                        {
                            CountryID = "cyp",
                            CategoryID = "indoor",
                            FlagImage = "flag-of-Cyprus.png",
                            GameID = "yo",
                            Name = "Cyprus"
                        },
                        new
                        {
                            CountryID = "rus",
                            CategoryID = "indoor",
                            FlagImage = "flag-of-Russia.png",
                            GameID = "yo",
                            Name = "Russia"
                        },
                        new
                        {
                            CountryID = "fin",
                            CategoryID = "outdoor",
                            FlagImage = "flag-of-Finland.png",
                            GameID = "yo",
                            Name = "Finland"
                        },
                        new
                        {
                            CountryID = "slo",
                            CategoryID = "outdoor",
                            FlagImage = "flag-of-Slovakia.png",
                            GameID = "yo",
                            Name = "Slovakia"
                        },
                        new
                        {
                            CountryID = "por",
                            CategoryID = "outdoor",
                            FlagImage = "flag-of-Portugal.png",
                            GameID = "yo",
                            Name = "Portugal"
                        });
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
