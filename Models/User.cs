using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingSystem.Models
{
    [Table("TblUser")]
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(20,ErrorMessage = "Max 20 char allowed"),MinLength(3,ErrorMessage = "Min 3 char required")]
        public string UserName { get; set; }

        //[Display(Name = "Last Name")]
        //[Required(ErrorMessage = "Last Name is Required")]
        //[MaxLength(20, ErrorMessage = "Max 20 char allowed"), MinLength(3, ErrorMessage = "Min 3 char required")]
        //public string LastName { get; set; }

        [Display(Name = "Email ID")]
        [Required(ErrorMessage = "Email ID is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is Required")]
        [MaxLength(20, ErrorMessage = "Max 20 char allowed"), MinLength(6, ErrorMessage = "Min 6 char required")]
        public string Password { get; set; }

        //[Display(Name = "Confirm Password")]
        //[DataType(DataType.Password)]
        //[Compare("Password",ErrorMessage = "Password not matched")]
        //[MaxLength(20, ErrorMessage = "Max 20 char allowed"), MinLength(6, ErrorMessage = "Min 6 char required")]
        //public string CPassword { get; set; }

        [Required(ErrorMessage ="Age is Required")]
        [Range(18,120,ErrorMessage = "User must be 18+")]
        public int Age { get; set; }

        [Display(Name = "Phone No")]
        [Required(ErrorMessage = "Phone Number is Required"), RegularExpression(@"^([0-9]{10})$",ErrorMessage ="Invalid Phone Number")]  
        [StringLength(10)]
        public string Phoneno { get; set; }

        //[Display(Name = "Aadhaar UID No")]
        //[RegularExpression(@"^([0-9]{12})$", ErrorMessage = "Invalid UID No")]
        //[StringLength(12)]
        //public string AadhaarUIDNo { get; set; }
    }
}
