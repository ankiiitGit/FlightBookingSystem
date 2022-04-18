using FlightBookingSystem.Data;
using FlightBookingSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem.Repository.DBRepository
{
    public class DBUserRepository : IUserRepository
    {
        FBSDbContext _dbContext;

        public DBUserRepository(FBSDbContext context)
        {
            _dbContext = context;
        }

        public List<FlightInfo> GetFlights(FlightInfo flightInfo) //(DateTime scheduledDeparture, string fromPlace, string toPlace);
        {
            IQueryable<FlightInfo> flightInfos = _dbContext.FlightInfos.AsNoTracking().AsQueryable()
                                                    .Where(flight => flight.ScheduledDeparture >= flightInfo.ScheduledDeparture);

            return flightInfos.ToList();
        }

        public string GeneratePNR()
        {
            var pnr = new StringBuilder();
            Random random = new Random();
            pnr.Append("IN");
            //pnr.Append(random.Next(100));//A random number between 0 and 100
            pnr.Append(random.Next(1, 9)); //between 1 and 9
            pnr.Append((char)(random.Next(1, 26) + 64)).ToString().ToUpper();
            pnr.Append(random.Next(10, 100)); //between 10 and 100

            return pnr.ToString();
        }

        
        public TicketBooking CreateTicket(TicketBooking ticketBooking) 
        {         
            string pnr = GeneratePNR();
            //TicketBooking booking = _dbContext.TicketBookings.AsNoTracking().FirstOrDefault(tkt => tkt.PNR == pnr);
            //if (booking != null) { GeneratePNR(); }            

            ticketBooking.PNR = pnr;
            _dbContext.TicketBookings.Add(ticketBooking);
            _dbContext.SaveChanges();
            return ticketBooking;
        }


        public List<TicketBooking> GetTicketBookings(string email) //View History of Tkt Bookings with EMail
        {
            IQueryable<TicketBooking> ticketBookings = _dbContext.TicketBookings.AsNoTracking().AsQueryable()
                                                        .Where(booking => booking.Email == email);

            return ticketBookings.ToList();
        }


        public TicketBooking CancelTicketBooking(int bookingID)
        {
            // only prior to a day(24 hours) before journey date //Set status as Cancelled
            TicketBooking booking = _dbContext.TicketBookings.AsNoTracking().FirstOrDefault(tkt => tkt.BookingID == bookingID);
            if (booking == null) return null;
            booking.TicketStatus = "Cancelled";

            _dbContext.TicketBookings.Update(booking);
            _dbContext.SaveChanges();
            return booking;
        }


        public TicketBooking GetTicketBookingPNR(string pnr) 
        {
            TicketBooking booking = _dbContext.TicketBookings.AsNoTracking().FirstOrDefault(tkt => tkt.PNR == pnr);
            return booking;
        }


    }
}
