using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTransactions
{
    public class Account
    {
        public decimal dispositionLimit = 1050;

        public Account(Bank bank, IPerson person)
        {
            Bank = bank;
            Person = person;
            History = new List<Transaction>();
            Loans = new List<Loan>();
            DispoCredit = new Dispo(dispositionLimit, bank.DispoInterestRate);
            InterestRate = bank.InterestRate;
        }
        public Bank Bank { get; }
        public IPerson Person { get; }

        public decimal Balance { get; private set; }

        public List<Transaction> History { get; }

        public float InterestRate { get; }

        public Dispo DispoCredit { get; }

        public List<Loan> Loans { get; }

        public void DoTransaction(Account to, decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException();
            }
            to.Bank.ManageTransaction(new Transaction(this, to, amount));
        }

        public void AddTransaction(Transaction transaction)
        {
            History.Add(transaction);

            if (transaction.From == this)
            {
                Balance -= transaction.Amount;
            }
            else
            {
                Balance += transaction.Amount;
            }
        }
    }
}
