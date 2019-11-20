using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FinalProject_team12.Models;

namespace Final_Project_Team12.Models
{
    public enum AccountTypes { Savings, Checking, IRA, Stock_Portfolio };

    public class StandardAccount
    {
        public StandardAccount()
        {
            if (Transactions == null)
            {
                Transactions = new List<Transaction>();
            }
        }

        // See utilities class of relational data demo for example of how to autogenerate starting at certain value
        [Display(Name = "Account Number")]
        public Int32 StandardAccountID { get; set; }

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

        // Navigational properties
        [Display(Name = "Transactions")]
        public List<Transaction> Transactions { get; set; }

        [Display(Name = "Account Owner")]
        public AppUser User { get; set; }

     }
}
