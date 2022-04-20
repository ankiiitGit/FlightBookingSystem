using FlightBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingSystem.DataModels
{
    public class TicketBookingDataModel
    {
        public string FlightNumber { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int NoofSeats { get; set; }
        public List<Passenger> passengers { get; set; }
        public string MealPreference { get; set; }
        public string SeatType { get; set; }
        public string SeatSelected { get; set; }
        public string PNR { get; set; }
        public string TicketStatus { get; set; }
    }
}
