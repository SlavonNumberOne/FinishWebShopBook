using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebShop.BusinessLogic.ViewModels
{
   public class LoginViewModel
    {
        [Required]
        public String Name { get; set; }

        [Required]
        public String Password { get; set; }
    }
}
