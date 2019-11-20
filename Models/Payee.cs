using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_team12.Models
{
    public enum PayeeType { CreditCard, Utilities, Rent, Mortgage, Other }

    public class Payee
    {
        [Display(Name = "Payee ID:")]
        public Int32 PayeeID { get; set; }

        [Required(ErrorMessage = "Please enter payee name")]
        [Display(Name = "Payee Name:")]
        public String PayeeName { get; set; }

        [Required(ErrorMessage = "Street is a required field.")]
        [Display(Name = "Street:")]
        public String Street { get; set; }

        [Required(ErrorMessage = "City is a required field.")]
        [Display(Name = "City:")]
        public String City { get; set; }

        [Required(ErrorMessage = "State is a required field.")]
        [Display(Name = "State:")]
        public String State { get; set; }

        [Required(ErrorMessage = "Zip code is a required field.")]
        [RegularExpression(@"\d{5}$", ErrorMessage = "Invalid Zip Code")]
        [Display(Name = "Zip Code:")]
        public String ZipCode { get; set; }

        [Required(ErrorMessage = "Phone number is a required field.")]
        [Display(Name = "Phone Number:")]
        public String PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please select a payee type")]
        [Display(Name = "Payee Type:")]
        public String PayeeType { get; set; }

        public List<Transaction> Transactions { get; set; }

        public Payee()
        {
            if (Transactions == null)
            {
                Transactions = new List<Transaction>();
            }
        }
    }
}