using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWineStore.Models
{
    public class CheckOutModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [CreditCard]
        public string CreditCardName { get; set; }
        public string CreditCardNumber { get; set; }
        [Required]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "CVV need to be three numbers")]
        public string CreditCardVerificationValue { get; set; }
        public int CreditCardExpirationDate { get; set; }
        public string ShippingAddress1 { get; set; }
        public string ShippingAddress2 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingPostalcode { get; set; }
       
    }
}