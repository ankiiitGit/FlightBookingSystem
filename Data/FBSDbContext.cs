using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightBookingSystem.Models;

namespace FlightBookingSystem.Data
{
    public class FBSDbContext : DbContext //IdentityDbContext<User>
    {
        public IConfiguration _configuration { get; }

        public FBSDbContext(DbContextOptions<FBSDbContext> options, IConfiguration configuration): base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("default"));
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.LogTo(Console.WriteLine, new[] { RelationalEventId.CommandExecuted });
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // You need this while creating Database through Code First approach
            modelBuilder.ModelConfig();
            modelBuilder.SeedData();
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Airline> Airlines { get; set; }

        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<FlightInfo> FlightInfos { get; set; }  

        public DbSet<TicketBooking> TicketBookings { get; set; }
    }
}
