using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingSystem.Models
{
    [Table("TblPassenger")]
    public class Passenger
    {
        public string PassengerName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
