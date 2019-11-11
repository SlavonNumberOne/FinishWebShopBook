using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebShop.BusinessLogic.ViewModels
{
   public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public String Email { get; set; }
        [Required]
        [Display(Name = "Password")]
        public String Password { get; set; }
    
    }
}
