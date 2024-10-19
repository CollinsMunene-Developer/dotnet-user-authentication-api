using System.ComponentModel.DataAnnotations;

namespace userAuthentication.Models {
    public class RegisterModel {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [StringLength(256, ErrorMessage = "Email is too long")]
        //email must be unique and correct format
        public string Email { get; set; }

        //for username
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, ErrorMessage = "Username is too long")]
        public string Username {get; set;}

        //for password
        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength=8,  ErrorMessage = "Password must be at least 8 characters long", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character")]
        public string Password { get; set; }


        //for confirm password
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        //for first name
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "First Name is too long")]
        public string FirstName { get; set; }

        //for last name
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name is too long")]
        public string LastName { get; set; }
        
        //for phone number
        [phone(ErrorMessage = "Invalid phone number")]
        [Required(ErrorMessage = "Phone Number is required")]
        [StringLength(20, ErrorMessage = "Phone Number is too long")]
        public string PhoneNumber { get; set; }



}
}