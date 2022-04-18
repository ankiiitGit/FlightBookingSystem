using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingSystem.Models
{
    [Table("TblFlightInfo")]
    public class FlightInfo
    {
        //Schedule Flight Controller to work on this Class

        [Key]
        public int FlightID { get; set; }

        [Display(Name = "Flight Number")]
        [Required(ErrorMessage = "Flight Number is Required")]
        [MaxLength(20, ErrorMessage = "Max 20 char allowed"), MinLength(5, ErrorMessage = "Min 5 char required eg SG732")]
        public string FlightNumber { get; set; }

        [Display(Name = "Starting City")]
        [Required(ErrorMessage = "Starting City is Required")]
        [MaxLength(20, ErrorMessage = "Max 20 char allowed"), MinLength(3, ErrorMessage = "Min 3 char required")]
        public string FromPlace { get; set; }

        [Display(Name = "Destination City")]
        [Required(ErrorMessage = "Destination City is Required")]
        [MaxLength(20, ErrorMessage = "Max 20 char allowed"), MinLength(3, ErrorMessage = "Min 3 char required")]
        public string ToPlace { get; set; }

        [Display(Name = "Scheduled Departure")]
        [Required(ErrorMessage = "Departure Date and Time is Required")]
        [DataType(DataType.DateTime)]
        public DateTime ScheduledDeparture { get; set; }

        [Display(Name = "Scheduled Arrival")]
        [Required(ErrorMessage = "Arrival Date and Time is Required")]
        [DataType(DataType.DateTime)]
        public DateTime ScheduledArrival { get; set; }

        public int AirlineID { get; set; }
        public virtual Airline AirlineInfo { get; set; }

        [Display(Name = "Ticket Price")]
        [Required(ErrorMessage = "Total Price is Required")]
        public float TotalPrice { get; set; }

        //[Display(Name = "Seat Type")]        
        //public string SeatType { get; set; }

        //[Display(Name = "Service Availability Days")]
        //[Required(ErrorMessage ="Service Availability is Required")]
        //public Dictionary<int, string> ServiceAvailabityDays { get; set; }

        [Display(Name = "Flight Model")]
        [Required(ErrorMessage ="Flight Model Name is Required")]
        public string FlightModel { get; set; }

        [Display(Name = "Number of Business Class Seats")]
        [Required(ErrorMessage = "Number of Business Class Seats Available is Required")]
        public int NoofBSeats { get; set; }

        [Display(Name = "Number of Economy Class Seats")]
        [Required(ErrorMessage = "Number of Economy Class Seats Available is Required")]
        public int NoofEconomySeats { get; set; }

        [Display(Name = "Number of Rows")]
        [Required(ErrorMessage = "Number of Rows is Required")]
        public int NoofRows { get; set; }

        //Give Veg, NonVeg and Both options in frontend and bring string value to backend to store in this field.
        [Display(Name = "Meals Available")]
        [Required(ErrorMessage = "Type of Meals Avaialble is Required")]
        public string MealsAvailable { get; set; }
    }
}
