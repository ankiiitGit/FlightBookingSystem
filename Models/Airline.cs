using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingSystem.Models
{
    [Table("TblAirline)")]
    public class Airline
    {
        [Key]
        public int AirlineID { get; set; }

        [Display(Name = "Airline Name")]
        [Required(ErrorMessage = "Airline Name is Required")]
        [MaxLength(30, ErrorMessage = "Max 20 char allowed"), MinLength(3, ErrorMessage = "Min 3 char required")]
        public string AirlineName { get; set; }

        [Display(Name = "Seating Capacity")]
        [Required(ErrorMessage ="Seating Capacity is Required")]
        public int SeatingCapacity { get; set; }

        //[DataType(DataType.ImageUrl)]
        //public string AirlineLogo { get; set; }

        //[Display(Name = "Contact Address")]
        //[Required(ErrorMessage = "Address is Required")]
        //[MaxLength(50, ErrorMessage = "Max 50 char allowed"), MinLength(10, ErrorMessage = "Min 3 char required")]
        //public string AirlineAddress { get; set; }

        //[Display(Name = "Contact No")]
        //[Required(ErrorMessage = "Contact Number is Required"), RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Contact Number")]
        //[StringLength(10)]
        //public string AirlineContactNo { get; set; }

        [Required(ErrorMessage ="Airline Status is Required")]
        public string AirlineStatus { get; set; }
    }
}
