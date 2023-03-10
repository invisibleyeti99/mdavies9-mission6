// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mdavies9_mission6.Models;

namespace mdavies9_mission6.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230214003913_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("mdavies9_mission6.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("movieId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            movieId = 1,
                            Category = "Action",
                            Director = "Steven Spielburg",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Troy",
                            Year = 1990
                        },
                        new
                        {
                            movieId = 2,
                            Category = "Comedy",
                            Director = "Michael Bay",
                            Edited = true,
                            Lent = "Bob",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "I am Legend",
                            Year = 2005
                        },
                        new
                        {
                            movieId = 3,
                            Category = "Adventure",
                            Director = "Jessie Pinkman",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "R",
                            Title = "Jumanji",
                            Year = 2015
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
