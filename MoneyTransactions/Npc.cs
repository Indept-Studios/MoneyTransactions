using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTransactions
{
    public class Npc : PersonBase
    {
        public Npc(string name) : base(name)
        {
            AvailableContracts = new List<Contract>();
        }
        public List<Contract> AvailableContracts { get; }
    }
}
