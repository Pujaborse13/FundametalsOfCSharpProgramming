using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation_DemoProject
{
   public  class UserRegistration
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage ="Name is required")]
        [StringLength(50,MinimumLength = 3,ErrorMessage ="Name Should be min 3 letters")]   //50 max len
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Only alphabets and spaces are allowed in Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = " Email is required")]
        [EmailAddress(ErrorMessage = "provide valid Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password is required to login ")]
        [StringLength(30,MinimumLength =8,ErrorMessage ="Passowrd must be min 8 letters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "The fields Password and PasswordConfirmation should be equals")]
        public string ConfirmPassword { get; set; }


        [Range(18, 85, ErrorMessage = "age should be 18 or above and below 85")]
        public int Age { get; set; }


        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(UserRegistration), "ValidateBirthDate")]
        public DateTime DateOfBirth { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        [Range(0, 1000000, ErrorMessage = "Salary must be between 0 and 1,000,000")]
        public decimal CurrentSalary { get; set; }


        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Required about you")]
        public string AboutYou { get; set; }


        [Url(ErrorMessage = "Invalid URL format")]
        public string Website { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }

        [CreditCard(ErrorMessage = "Invalid credit card number")]
        public string CreditCardNumber { get; set; }


        
        public static ValidationResult ValidateBirthDate(DateTime birthDate, ValidationContext context)
        {
            if (birthDate > DateTime.Now)
            {
                return new ValidationResult("Date of Birth cannot be in the future.");
            }
            return ValidationResult.Success;
        }






    }
}
