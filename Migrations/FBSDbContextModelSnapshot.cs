﻿// <auto-generated />
using System;
using FlightBookingSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlightBookingSystem.Migrations
{
    [DbContext(typeof(FBSDbContext))]
    partial class FBSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FlightBookingSystem.Models.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("AdminID");

                    b.ToTable("tblAdmin");

                    b.HasData(
                        new
                        {
                            AdminID = 1,
                            AdminName = "Admin",
                            Password = "P@ssword"
                        });
                });

            modelBuilder.Entity("FlightBookingSystem.Models.Airline", b =>
                {
                    b.Property<int>("AirlineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AirlineName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("AirlineStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeatingCapacity")
                        .HasColumnType("int");

                    b.HasKey("AirlineID");

                    b.ToTable("TblAirline");

                    b.HasData(
                        new
                        {
                            AirlineID = 1,
                            AirlineName = "Indigo",
                            AirlineStatus = "Active",
                            SeatingCapacity = 200
                        });
                });

            modelBuilder.Entity("FlightBookingSystem.Models.FlightInfo", b =>
                {
                    b.Property<int>("FlightID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirlineID")
                        .HasColumnType("int");

                    b.Property<string>("FlightModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlightNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FromPlace")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MealsAvailable")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoofBSeats")
                        .HasColumnType("int");

                    b.Property<int>("NoofEconomySeats")
                        .HasColumnType("int");

                    b.Property<int>("NoofRows")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScheduledArrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ScheduledDeparture")
                        .HasColumnType("datetime2");

                    b.Property<string>("ToPlace")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("FlightID");

                    b.HasIndex("AirlineID");

                    b.ToTable("TblFlightInfo");
                });

            modelBuilder.Entity("FlightBookingSystem.Models.Passenger", b =>
                {
                    b.Property<int>("PassengerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassengerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TicketBookingBookingID")
                        .HasColumnType("int");

                    b.HasKey("PassengerID");

                    b.HasIndex("TicketBookingBookingID");

                    b.ToTable("TblPassenger");
                });

            modelBuilder.Entity("FlightBookingSystem.Models.TicketBooking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlightNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MealPreference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoofSeats")
                        .HasColumnType("int");

                    b.Property<string>("PNR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeatSelected")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeatType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TicketStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("BookingID");

                    b.ToTable("TblTicketBooking");
                });

            modelBuilder.Entity("FlightBookingSystem.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phoneno")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserID");

                    b.ToTable("TblUser");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Age = 25,
                            Email = "ashishankitmishra@gmail.com",
                            Password = "P@ssword",
                            Phoneno = "9667516101",
                            UserName = "Ashish"
                        });
                });

            modelBuilder.Entity("FlightBookingSystem.Models.FlightInfo", b =>
                {
                    b.HasOne("FlightBookingSystem.Models.Airline", "AirlineInfo")
                        .WithMany()
                        .HasForeignKey("AirlineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirlineInfo");
                });

            modelBuilder.Entity("FlightBookingSystem.Models.Passenger", b =>
                {
                    b.HasOne("FlightBookingSystem.Models.TicketBooking", null)
                        .WithMany("passengers")
                        .HasForeignKey("TicketBookingBookingID");
                });

            modelBuilder.Entity("FlightBookingSystem.Models.TicketBooking", b =>
                {
                    b.Navigation("passengers");
                });
#pragma warning restore 612, 618
        }
    }
}
