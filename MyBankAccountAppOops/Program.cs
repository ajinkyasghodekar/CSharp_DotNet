using System;

namespace MyBankAccountApp
{
    class Program
    {
        static void Main (string[] args)
        {
            // Step I 
            var Account1 = new BankAccount ("Ajinkya", 10000);
            Console.WriteLine($"A new bank account has been created for {Account1.Owner}, with Account number {Account1.Number} and Initial balance is {Account1.Balance}");

            // Step II
            Account1.Withdrawl(120, DateTime.Now, "Rupees");
            Console.WriteLine(Account1.Balance);

            // // Step III
            // BankAccount invalidAccount;
            // try
            // {
            //     invalidAccount = new BankAccount("invalid", -55);
            // }
            // catch (ArgumentOutOfRangeException e)
            // {
            //     Console.WriteLine("Exception caught creating account with negative balance");
            //     Console.WriteLine(e.ToString());
            // }

            // // Test for a negative balance.
            // try
            // {
            //     Account1.Withdrawl(75000, DateTime.Now, "Attempt to overdraw");
            // }
            // catch (InvalidOperationException e)
            // {
            //     Console.WriteLine("Exception caught trying to overdraw");
            //     Console.WriteLine(e.ToString());
            // }

            Account1.Withdrawl(50, DateTime.Now, "Game");
            Console.WriteLine(Account1.Balance);

            // Get account history
            Console.WriteLine(Account1.getAccountHistory());
        
        }
    }
}