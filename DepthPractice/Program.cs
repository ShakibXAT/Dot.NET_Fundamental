using System;

namespace DepthPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Shakib", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owener} with {account.Balance} initial balance");
            
            account.MakeWithdrawl(500, DateTime.Now, "Rent Payment");
            Console.WriteLine(account.Balance);
            
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine((e.ToString()));
            }

        }
    }
}