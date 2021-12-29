using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTransactions
{
    public class Dispo
    {
        public Dispo(decimal maximumAmount, float interestRate)
        {
            MaximumAmount = maximumAmount;
            InterestRate = interestRate;
        }
        public decimal MaximumAmount { get; }
        public float InterestRate { get; }
    }
}
