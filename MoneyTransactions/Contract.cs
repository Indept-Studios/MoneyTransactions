using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTransactions
{
    public class Contract
    {
        public Contract(IPerson person, Cargo cargoType, Destination from, Destination to, Destination distance, float profitAmount, float penaltyAmount)
        {
            Person = person;
            CargoType = cargoType;
            From = from;
            To = to;
            Distance = distance;
            ProfitAmount = profitAmount;
            PenaltyAmount = penaltyAmount;
        }

        public IPerson Person { get; }
        public Cargo CargoType { get; }
        public Destination From { get; }
        public Destination To { get; }
        public Destination Distance { get; }
        public float ProfitAmount { get; }
        public float PenaltyAmount { get; }
        public bool IsDone { get; }
        public bool IsDoneInTime { get; }

        public void JobFinished()
        {
            if (IsDone)
            {
                //ProfitAmount to Transaction

                if (IsDoneInTime)
                {
                    //Bonusprofit to Transaction
                }
                else
                {
                    //PenaltyAmount to Transaction
                }
            }
        }
    }
}
