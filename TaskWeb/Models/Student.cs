using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TaskWeb.Utilities;

namespace TaskWeb.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter First Name")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "The First Name must be between 3 and 15 characters long!")]
        [DisplayName("First Name :")]
        [ValidateName(ErrorMessage = "The Fisrt Charecter of Name must be Capital and don't contains any Symbol or Number")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "The Last Name must be between 3 and 15 characters long!")]
        [ValidateName(ErrorMessage = "The Fisrt Charecter of Name must be Capital and don't contains any Symbol or Number")]
        [DisplayName("Last Name :")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone Number")]
        [StringLength(15, MinimumLength = 15, ErrorMessage = "The Phone Number must be 15 characters long!")]
        //[DataType(DataType.PhoneNumber)]

        [ValidateNumber(ErrorMessage = "The number must be start with +966")]
        
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "You must Provide a Date of Birth")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString = "dd/MM/yyyy", ApplyFormatInEditMode = true)]
        [ValidateDOB(ErrorMessage = "Invalid Date of Birth")]
        [DisplayName("Date of Birth :")]
        public string DOB { get; set; }
    }
}
