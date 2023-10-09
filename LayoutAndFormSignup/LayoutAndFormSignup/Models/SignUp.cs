using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LayoutAndFormSignup.Models
{
    public class SignUp
    {
        [Required(ErrorMessage = "Provide Your name")]
        [StringLength(25,ErrorMessage ="Length <25")]
        public string name { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public string profession { get; set; }
        [Required]
        public string[] hobbies { get; set; }
    }
}