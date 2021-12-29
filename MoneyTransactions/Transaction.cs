using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTransactions
{
    public class Transaction
    {
        public Transaction(Account from, Account to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
        public Account From { get; }
        public Account To { get; }
        public decimal Amount { get; }
        public Transaction Reverse()
        {
            return new Transaction(To, From, -Amount);
        }
    }
}
