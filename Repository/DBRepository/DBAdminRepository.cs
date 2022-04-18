using FlightBookingSystem.Data;
using FlightBookingSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingSystem.Repository.DBRepository
{
    public class DBAdminRepository : IAdminRepository
    {
        FBSDbContext _dbContext;

        public DBAdminRepository(FBSDbContext context)
        {
            _dbContext = context;
        }

        public Airline CreateAirline(Airline airline) //Default status to Active
        {
            _dbContext.Airlines.Add(airline);
            _dbContext.SaveChanges();
            return airline;

        }

        public Airline BlockAirline(int airlineID) //Change status to Blocked
        {
            Airline airline = _dbContext.Airlines.AsNoTracking().FirstOrDefault(air => air.AirlineID == airlineID);
            if (airline == null) return null;
            airline.AirlineStatus = "Blocked";

            _dbContext.Airlines.Update(airline);
            _dbContext.SaveChanges();
            return airline;

        }

        public List<Airline> GetAirlines() //Get All Airlines
        {
            //IQueryable<Airline> airlines = _dbContext.Airlines.AsNoTracking().AsQueryable();                                                    

            return _dbContext.Airlines.ToList();
        }

        public FlightInfo CreateFlightInfo(FlightInfo flightInfo)
        {
            _dbContext.FlightInfos.Add(flightInfo);
            _dbContext.SaveChanges();
            return flightInfo;

        }

    }
}
