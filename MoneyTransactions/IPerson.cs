using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTransactions
{
    public interface IPerson
    {
        List<Account> Accounts { get; }
    }
}
