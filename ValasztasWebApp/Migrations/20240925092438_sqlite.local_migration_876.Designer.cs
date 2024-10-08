﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ValasztasWebApp.Models;

#nullable disable

namespace ValasztasWebApp.Migrations
{
    [DbContext(typeof(ValasztasDbContext))]
    [Migration("20240925092438_sqlite.local_migration_876")]
    partial class sqlitelocal_migration_876
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("ValasztasWebApp.Models.Jelolt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kerulet")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PartRovidNev")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Szavazatok")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PartRovidNev");

                    b.ToTable("Jeloltek");
                });

            modelBuilder.Entity("ValasztasWebApp.Models.Part", b =>
                {
                    b.Property<string>("RovidNev")
                        .HasColumnType("TEXT");

                    b.Property<string>("TeljesNev")
                        .HasColumnType("TEXT");

                    b.HasKey("RovidNev");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("ValasztasWebApp.Models.Jelolt", b =>
                {
                    b.HasOne("ValasztasWebApp.Models.Part", "Part")
                        .WithMany("Jeloltek")
                        .HasForeignKey("PartRovidNev")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Part");
                });

            modelBuilder.Entity("ValasztasWebApp.Models.Part", b =>
                {
                    b.Navigation("Jeloltek");
                });
#pragma warning restore 612, 618
        }
    }
}
