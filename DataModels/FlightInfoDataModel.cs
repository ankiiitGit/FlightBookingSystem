using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingSystem.DataModels
{
    public class FlightInfoDataModel
    {
        public string FlightNumber { get; set; }
        public string FromPlace { get; set; }
        public string ToPlace { get; set; }
        public DateTime ScheduledDeparture { get; set; }
        public DateTime ScheduledArrival { get; set; }
        public int AirlineID { get; set; }
        public float TotalPrice { get; set; }
        public string FlightModel { get; set; }
        public int NoofBSeats { get; set; }
        public int NoofEconomySeats { get; set; }
        public int NoofRows { get; set; }
        public string MealsAvailable { get; set; }
    }
}
