using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Final_Project_Team12.Models;

namespace FinalProject_team12.Models
{
    public class IRAAccount
    {
        public IRAAccount()
        {
            AccountType = AccountTypes.IRA;
        }

        ///Customer must be younger than 70 years old --> put this in later
        ///get current date and subtract customer's birth date (from 

        // See utilities class of relational data demo for example of how to autogenerate starting at certain value
        [Display(Name = "Account Number")]
        public Int32 IRAAccountID { get; set; }

        [Required]
        [Display(Name = "Account Type")]
        public AccountTypes AccountType { get; set; }

        [Required]
        [Display(Name = "Account Name")]
        public string AccountName { get; set; }

        [Display(Name = "Initial Deposit")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal InitialDeposit { get; set; }

        [Display(Name = "Available Balance")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal AvailableBalance { get; set; }

        [Display(Name = "Pending Amounts")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PendingAmounts { get; set; }

        //Not sure if this will work, but idea is there!
        [Display(Name = "Total Balance")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalBalance
        {
            get { return PendingAmounts + AvailableBalance; }
            set { TotalBalance = value; }
        }

        [Display(Name = "Active Account?")]
        public bool IsActive { get; set; }

        [Display(Name = "Transactions")]
        public List<Transaction> Transactions { get; set; }

        // Having issues with this one to one relationship
        [Display(Name = "Account Owner")]
        public AppUser User { get; set; }

        [Range(minimum: 0, maximum: 5000)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Contributions { get; set; }
    }
}
