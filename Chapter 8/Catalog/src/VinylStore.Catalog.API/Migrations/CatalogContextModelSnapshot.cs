﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using VinylStore.Catalog.Infrastructure;

namespace VinylStore.Catalog.API.Migrations
{
    [DbContext(typeof(CatalogContext))]
    partial class CatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VinylStore.Catalog.Domain.Entities.Artist", b =>
                {
                    b.Property<Guid>("ArtistId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArtistName");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("VinylStore.Catalog.Domain.Entities.Genre", b =>
                {
                    b.Property<Guid>("GenreId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GenreDescription");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("VinylStore.Catalog.Domain.Entities.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ArtistId");

                    b.Property<int>("AvailableStock");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("Format");

                    b.Property<Guid>("GenreId");

                    b.Property<bool>("IsInactive");

                    b.Property<string>("LabelName");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PictureUri");

                    b.Property<string>("Price");

                    b.Property<DateTimeOffset>("ReleaseDate");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Items","catalog");
                });

            modelBuilder.Entity("VinylStore.Catalog.Domain.Entities.Item", b =>
                {
                    b.HasOne("VinylStore.Catalog.Domain.Entities.Artist", "Artist")
                        .WithMany("Items")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("VinylStore.Catalog.Domain.Entities.Genre", "Genre")
                        .WithMany("Items")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
