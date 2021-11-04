using BankLibray;
using System;
using Humanizer;



namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Venicio", 10000);
            Console.WriteLine($" Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(60, DateTime.Now, "PS5 Game");
            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
            account.MakeWithdrawal(70, DateTime.Now, "Switch Game");
            account.MakeWithdrawal(400, DateTime.Now, "PS5 Console");


            Console.WriteLine(account.GetAccountHistory());

            Console.WriteLine("Press Enter to exit.");

            Console.ReadLine();
        }
    }
}
