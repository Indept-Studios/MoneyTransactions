using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTransactions
{
    public class Player : PersonBase
    {
        public Player(string name) : base(name)
        {
        }
        public List<Contract> AcceptedContracts { get; }
    }
}
