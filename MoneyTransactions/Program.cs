using System;
using System.Diagnostics.Contracts;
using System.Threading;

namespace MoneyTransactions
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank("VOBA");
            b.InterestRate = 0.1f;
            b.DispoInterestRate = 0.15f;
            var p1 = new Player("Harald");
            var p2 = new Npc("Hans Peter");
            var p1Acc = b.AddAccount(p1);
            var p2Acc = b.AddAccount(p2);
            Cargo cargo = new Cargo();
            Destination d1 = new Destination();
            Destination d2 = new Destination();
            Destination duration = new Destination();
            p2.AvailableContracts.Add(new Contract(p2, cargo, d1, d2, duration, 2000, 4000));
            //p1.ProvidingContracts.Add(new Contract());

            Console.WriteLine(p1.Name.PadRight(50) + p2.Name);
            Console.WriteLine();


            Console.WriteLine(p1Acc.Balance.ToString("0.00").PadRight(50) + p2Acc.Balance.ToString("0.00"));

            p1Acc.DoTransaction(p2Acc, 1000);


            Console.WriteLine(p1Acc.Balance.ToString("#.##").PadRight(50) + p2Acc.Balance.ToString("#.##"));
            Console.WriteLine();


            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(350);

                Console.WriteLine(p1Acc.Balance.ToString("#.##").PadRight(50) + p2Acc.Balance.ToString("#.##"));

                b.NextDay();
            }


            Console.ReadKey();
        }
    }
}
