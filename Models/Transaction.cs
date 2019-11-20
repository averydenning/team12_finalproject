using System;
using System.ComponentModel.DataAnnotations;
using Final_Project_Team12.Models;

namespace FinalProject_team12.Models
{
    public class Transaction
    {
        public enum TransactionTypes { Withdrawal, Deposit, Transfer, Payment }

        //Transaction parent properties
        [Display(Name = "Transaction Number:")]
        public Int32 TransactionID { get; set; }

        [Display(Name = "Transaction Type:")]
        public TransactionTypes Type { get; set; }

        [Display(Name = "Transaction Date:")]
        [DataType(DataType.Date)]
        public DateTime TransactionDate { get; set; }

        [Display(Name = "Transaction Amount:")]
        [Range(0, 1000000)]
        public Decimal TransactionAmount { get; set; }

        [Display(Name = "Transaction Description:")]
        public String TransactionDescription { get; set; }

        //Transfers
        [Display(Name = "From Account Number:")]
        public Int32 OriginatingAccount { get; set; }
        [Display(Name = "To Account Number:")]
        public Int32 DestinationAccount { get; set; }

        //Deposit
        [Display(Name = "Approval Status:")]
        public Boolean ApprovalStatus { get; set; }

        // Navigational properties
        [Display(Name = "Associated Account")]
        public StandardAccount StandardAccount { get; set; }

        [Display(Name = "Associated Account")]
        public IRAAccount IRAAccount { get; set; }

        //Payment - amount and date already declared above
        //need to make payee model
        public Payee Payee { get; set; }

        public Transaction()
        {
        }
    }
}
