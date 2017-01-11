﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWineStore.Models
{
    
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
         public string EmailAddress { get; set; }
        [Required]
         public string Password { get; set; }

       
    }
    public class ResetPasswordModel
    {
        [Required]
        public string ResetToken { get; set; }
        public string Password { get; set; }
    }

}
