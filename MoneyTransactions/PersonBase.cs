using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MoneyTransactions
{
    public abstract class PersonBase : IPerson
    {
        protected PersonBase(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public List<Account> Accounts { get; }
        public List<Contract> ProvidingContracts { get; }
    }
}
