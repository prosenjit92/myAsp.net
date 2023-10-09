using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace SignupValicaion.Models
{
    public class Signup
    {
        [Required(ErrorMessage = "Provide Your name and Length must be 4 to 50 Characters)")]
        [MinLength(4), MaxLength(50)]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name can only contain letters and spaces.")]
        public string name { get; set; }

        [Required(ErrorMessage = "Provide Your userid and Length must be 4 to 12 Characters")]
        [RegularExpression(@"^[A-Za-z0-9\-_]{4,12}$", ErrorMessage = "User ID must be 4 to 12 characters long and can only contain letters, numbers, dashes, and underscores.")]
        public string userid { get; set; }

        [Required(ErrorMessage = "*Provide you Password")]
        [StringLength(60, MinimumLength = 8, ErrorMessage = "lenght should be min 8")]
        //[RegularExpression("^(?=(?:[^A-Z]*[A-Z]){1})(?=(?:[^a-z]*[a-z]){2})[A-Za-z]{4}(?=.*[0-9!@#$%^&*])[0-9!@#$%^&*]+",ErrorMessage = "Password must meet the specified criteria.")]
        public string password { get; set; }
        [Required(ErrorMessage = "*Provide you id")]
        [RegularExpression("^\\d{2}-\\d{5}-\\d$", ErrorMessage = "ID must be in XX-XXXX-X format")]
        public string id { get; set; }
       
        [Required(ErrorMessage = "*Provide you email")]

        [RegularExpression("^\\d{2}-\\d{5}-\\d@student.aiub.edu$", ErrorMessage = "email format no correct")]
        public string email { get; set; }
        [Required(ErrorMessage = "*Select date")]
        public string dob { get; set; }
    }
}