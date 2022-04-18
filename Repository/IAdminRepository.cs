using FlightBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingSystem.Repository
{
    public interface IAdminRepository
    {
        public Airline CreateAirline(Airline airline); //Default status to Active
        public Airline BlockAirline(int airlineID); //Change status to Blocked
        public List<Airline> GetAirlines();

        public FlightInfo CreateFlightInfo(FlightInfo flightInfo);

    }
}
