﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wizme.Entities;

namespace Wizme.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Wizme.Entities.Space", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<string>("Shape");

                    b.Property<Guid>("VenueId");

                    b.HasKey("Id");

                    b.HasIndex("VenueId");

                    b.ToTable("Spaces");

                    b.HasData(
                        new
                        {
                            Id = new Guid("59bc648c-4df3-4eb5-a71f-601e5a139ca4"),
                            Price = 1.01,
                            Shape = "U-Theatre",
                            VenueId = new Guid("02d54ac3-93e0-4766-918a-9a83786ae1fd")
                        },
                        new
                        {
                            Id = new Guid("8f1b65ea-5c1e-4c01-8208-bdddc6f2af24"),
                            Price = 1.01,
                            Shape = "Shape2",
                            VenueId = new Guid("02d54ac3-93e0-4766-918a-9a83786ae1fd")
                        },
                        new
                        {
                            Id = new Guid("4a13b39b-bb4c-4979-9509-899c206db6bb"),
                            Price = 1.01,
                            Shape = "Shape3",
                            VenueId = new Guid("02d54ac3-93e0-4766-918a-9a83786ae1fd")
                        },
                        new
                        {
                            Id = new Guid("484b86b0-295e-4535-8fcd-72ca39de4eed"),
                            Price = 2.0,
                            Shape = "Square",
                            VenueId = new Guid("f790c5a4-3e8d-4834-afbe-473ac318fdec")
                        },
                        new
                        {
                            Id = new Guid("32b2639d-23aa-4b42-9957-ff0e1a6f34d5"),
                            Price = 2.0,
                            Shape = "3atees",
                            VenueId = new Guid("f790c5a4-3e8d-4834-afbe-473ac318fdec")
                        });
                });

            modelBuilder.Entity("Wizme.Entities.Venue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("Chain");

                    b.Property<string>("Descreption");

                    b.Property<string>("Img");

                    b.HasKey("Id");

                    b.ToTable("Venues");

                    b.HasData(
                        new
                        {
                            Id = new Guid("02d54ac3-93e0-4766-918a-9a83786ae1fd"),
                            Descreption = "my first venue"
                        },
                        new
                        {
                            Id = new Guid("f790c5a4-3e8d-4834-afbe-473ac318fdec"),
                            Descreption = "my second venue"
                        },
                        new
                        {
                            Id = new Guid("086b08e7-623c-4832-b557-230b9b5b82cb"),
                            Descreption = "my third venue"
                        });
                });

            modelBuilder.Entity("Wizme.Entities.Space", b =>
                {
                    b.HasOne("Wizme.Entities.Venue", "Venue")
                        .WithMany("Spaces")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
