using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LayoutAndFormSignup.Models
{
    public class SignUp1
    {
        [Required(ErrorMessage = "Provide Your name (Length 4 to 50 Characters)")]
        [MinLength(4), MaxLength(50)]
        public string name {  get; set; }
        [Required]
        public string userid {  get; set; }

        [Required]
        public string password {  get; set; }
        [Required]
        public string id {  get; set; }
        [Required]
        public string email {  get; set; }
        [Required]
        public string dob { get; set; }
    }
}