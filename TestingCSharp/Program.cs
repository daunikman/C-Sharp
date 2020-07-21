using System;

namespace TestingCSharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Testing C Sharp";
            Console.BackgroundColor = ConsoleColor.Red;

            Account account = new Account();
            account.Balance = 2400;
            account.DepositCash(2300);
            account.FirstName = "Ojo";
            account.LastName = "Ilesanmi";
            Console.WriteLine(account.Balance);
            account.Pin = 2233;
            account.WithdrawCash(1500, 1323);
        }
    }
}