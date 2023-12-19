﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Space_Booking_System.myDbContext;

#nullable disable

namespace Space_Booking_System.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231219190545_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Space_Booking_System.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"), 1L, 1);

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("BookingTime")
                        .HasColumnType("time");

                    b.Property<int>("SpaceID")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingID");

                    b.HasIndex("SpaceID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Space_Booking_System.Models.Space", b =>
                {
                    b.Property<int>("SpaceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpaceID"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("SpaceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpaceID");

                    b.ToTable("Spaces");
                });

            modelBuilder.Entity("Space_Booking_System.Models.Booking", b =>
                {
                    b.HasOne("Space_Booking_System.Models.Space", "Space")
                        .WithMany("Bookings")
                        .HasForeignKey("SpaceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Space");
                });

            modelBuilder.Entity("Space_Booking_System.Models.Space", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
