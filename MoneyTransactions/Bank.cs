using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MoneyTransactions
{
    public class Bank : IPerson
    {
        public Bank(string name)
        {
            Name = name;
            Accounts = new List<Account>() { new Account(this, this) };
            Customers = new Dictionary<IPerson, List<Account>>();
        }
        public Account Account => Accounts[0];
        public Dictionary<IPerson, List<Account>> Customers { get; }

        public string Name { get; }

        public float InterestRate { get; set; }

        public float DispoInterestRate { get; set; }

        public float CreditInterestRate { get; set; }

        public List<Account> Accounts { get; }

        public void ManageTransaction(Transaction transaction)
        {
            transaction.From.AddTransaction(transaction);
            transaction.To.AddTransaction(transaction);
        }

        public void ManageLoans(Account account)
        {
            foreach(var loan in account.Loans)
            {
                
            }
        }

        public Account AddAccount(IPerson person)
        {
            var acc = new Account(this, person);
            if (!Customers.TryGetValue(person, out var accounts))
            {
                accounts = new List<Account>();
                Customers.Add(person, accounts);
            }
            accounts.Add(acc);
            return acc;
        }

        public void NextDay()
        {
            foreach(var customer in Customers)
            {
                foreach(var acc in customer.Value)
                {
                    if (acc.Balance < 0)
                    {
                        ManageTransaction(new Transaction(Account, acc, acc.Balance * (decimal)acc.DispoCredit.InterestRate / 30));

                        if (acc.Balance < -acc.DispoCredit.MaximumAmount)
                        {
                            Console.WriteLine(((acc.Person as PersonBase)?.Name ?? "Unknown entity") + " has gone bankrupt"); 
                        }
                    }
                    else if (acc.Balance > 0)
                    {
                        ManageTransaction(new Transaction(Account, acc, acc.Balance * (decimal)acc.InterestRate / 30));
                    }

                    ManageLoans(acc);
                }
            }
        }
    }
}
