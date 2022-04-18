using FlightBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingSystem.Repository
{
    public interface IUserRepository
    {
        public List<FlightInfo> GetFlights(FlightInfo flightInfo); //(DateTime dateTime, string fromPlace, string toPlace);
        public TicketBooking CreateTicket(TicketBooking ticketBooking);
        public List<TicketBooking> GetTicketBookings(string email);
        public TicketBooking CancelTicketBooking(int bookingID); // only prior to a day(24 hours) before journey date //Set status as Cancelled
        public TicketBooking GetTicketBookingPNR(string pnr);

    }
}
