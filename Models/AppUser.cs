using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Final_Project_Team12.Models
{
    public class AppUser : IdentityUser
    {
        //First name is provided as an example
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        //
        [Display(Name = "Middle Initial")]
        public String MiddleInitial { get; set; }

        //
        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        //NEED TO ADD BIRTH DAY - required - allows us to track age for IRA account eligibility 

        //
        [Required(ErrorMessage = "Street is required.")]
        [Display(Name = "Street")]
        public String Street { get; set; }

        //
        [Required(ErrorMessage = "City is required.")]
        [Display(Name = "City")]
        public String City { get; set; }

        //
        [Required(ErrorMessage = "State is required.")]
        [Display(Name = "State")]
        public String State { get; set; }

        //
        [Required(ErrorMessage = "Zip code is required.")]
        [Display(Name = "Zip code")]
        public String Zip { get; set; }

        [Display(Name = "Standard Accounts")]
        public List<StandardAccount> StandardAccounts { get; set; }

        // Having an issue with this one to one relationship. Need to go to office hours to figure it out.
        //[Display(Name = "IRA Account")]
        //public IRAAccount IRAAccount { get; set; }

        [Display(Name = "Is user active?")]
        public Boolean IsActive { get; set; }
    }
}
