using FlightBookingSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingSystem.Data
{
    //Extension method which talks about how to create your data definition and can also do DDL i.e. Initial Data field
    public static class ModelBuilderExtensions
    {
        public static void ModelConfig(this ModelBuilder modelBuilder)
        {
            //DDL
            //modelBuilder.Entity<User>().ToTable("User");
            //modelBuilder.Entity<Admin>().ToTable("Admin");
        }

        public static void SeedData(this ModelBuilder modelBuilder)
        {
            //DML using FLuent API
            modelBuilder.Entity<User>().HasData(
                new User 
                { 
                    UserID = 1, 
                    UserName = "Ashish", 
                    Email = "ashishankitmishra@gmail.com", 
                    Age = 25, 
                    Password = "P@ssword", 
                    Phoneno = "9667516101" 
                } );


            modelBuilder.Entity<Admin>().HasData(
                new Admin 
                { 
                    AdminID = 1, 
                    AdminName = "Admin", 
                    Password = "P@ssword" 
                } );

            modelBuilder.Entity<Airline>().HasData(
                new Airline 
                { 
                    AirlineID = 1, 
                    AirlineName = "Indigo", 
                    AirlineStatus = "Active", 
                    SeatingCapacity = 200 
                });

            //modelBuilder.Entity<Passenger>().HasData(
            //    new Passenger {  });

            //modelBuilder.Entity<FlightInfo>().HasData(
            //    new FlightInfo {  });

            //modelBuilder.Entity<TicketBooking>().HasData(
            //    new TicketBooking {  });

        }

    }
}
