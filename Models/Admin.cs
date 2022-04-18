using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingSystem.Models
{
    [Table("tblAdmin")]
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Display(Name = "Admin Name")]
        [Required(ErrorMessage = "Admin Name is Required")]
        [MaxLength(20, ErrorMessage = "Max 20 char allowed"), MinLength(3, ErrorMessage = "Min 3 char required")]
        public string AdminName { get; set; }

        //[Display(Name = "Last Name")]
        //[Required(ErrorMessage = "Last Name is Required")]
        //[MaxLength(20, ErrorMessage = "Max 20 char allowed"), MinLength(3, ErrorMessage = "Min 3 char required")]
        //public string LastName { get; set; }

        //[Display(Name = "Email ID")]
        //[Required(ErrorMessage = "Email ID is Required")]
        //[DataType(DataType.EmailAddress)]
        //public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is Required")]
        [MaxLength(20, ErrorMessage = "Max 20 char allowed"), MinLength(6, ErrorMessage = "Min 6 char required")]
        public string Password { get; set; }
    }
}
