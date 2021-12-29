using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTransactions
{
    public class Loan
    {
        public Loan(decimal amount, float creditInterestRate)
        {
            Amount = amount;
            CreditInterestRate = creditInterestRate;
        }
        public decimal Amount { get; }
        public float CreditInterestRate { get; }
        public DateTime Date { get; }
        public int Days { get; }
    }
}
