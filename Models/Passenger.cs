using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingSystem.Models
{
    [Table("TblPassenger")]
    public class Passenger
    {
        [Key]
        public int PassengerID { get; set; }
        public string PassengerName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
