using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingSystem.Models
{
    [Table("TblTicketBooking")]
    public class TicketBooking
    {
        //Ticket Booking Controller to work on this Class

        [Key]
        public int BookingID { get; set; }

        [Display(Name = "Flight Number")]
        [Required(ErrorMessage = "Flight Number is Required")]
        [MaxLength(20, ErrorMessage = "Max 20 char allowed"), MinLength(5, ErrorMessage = "Min 5 char required eg SG732")]
        public string FlightNumber { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(20, ErrorMessage = "Max 20 char allowed"), MinLength(3, ErrorMessage = "Min 3 char required")]
        public string UserName { get; set; }

        //[Display(Name = "Last Name")]
        //[Required(ErrorMessage = "Last Name is Required")]
        //[MaxLength(20, ErrorMessage = "Max 20 char allowed"), MinLength(3, ErrorMessage = "Min 3 char required")]
        //public string LastName { get; set; }

        [Display(Name = "Email ID")]
        [Required(ErrorMessage = "Email ID is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Number of Seats")]
        [Required(ErrorMessage = "Number of Seats is Required")]
        public int NoofSeats { get; set; }

        public List<Passenger> passengers { get; set; } //Store multiple passengers based on No of Seats Required

        [Display(Name = "Meal Preference")]
        [Required(ErrorMessage = "Meal Preference is Required")]
        public string MealPreference { get; set; }

        //public string DiscountCode { get; set; }

        [Display(Name = "Seat Type")]
        [Required(ErrorMessage = "Seat Type is Required")]
        public string SeatType { get; set; } //Business or Economy

        [Display(Name = "Selected Seat Number")]
        [Required(ErrorMessage = "Seat Selection is Required")]
        public string SeatSelected { get; set; } // Make this String to have 21A, 23D kind of seat numbers.

        //[Display(Name = "Return Seat Number")]
        //[Required(ErrorMessage = "Seat Selection is Required")]
        //public int ReturnSeatSelected { get; set; }

        public string PNR { get; set; } //Initialize a PNR and increment from Controller

        public string TicketStatus { get; set; } //Active or Cancelled        

    }
}

//{
//    "userName": "Ashish Ankit",
//  "email": "ashish111@gmail.com",
//  "noofSeats": 1,
//  "passengers": [
//    {
//        "passengerID": 0,
//      "passengerName": "Ashish Ankit",
//      "gender": "Male",
//      "age": 25
//    }
//  ],
//  "mealPreference": "Veg",
//  "seatType": "Economy",
//  "seatSelected": 21A,
//  "pnr": "string",
//  "ticketStatus": "Active"
//}
