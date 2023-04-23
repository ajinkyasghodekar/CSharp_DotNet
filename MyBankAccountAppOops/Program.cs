using System;

namespace MyBankAccountApp
{
    class Program
    {
        static void Main (string[] args)
        {
            // Step I
            var Account = new BankAccount ("Ajinkya", 10000);
            Console.WriteLine($"A new bank account has been created for {Account.Owner}, with Account number {Account.Number} and Initial balance is {Account.Balance}");
        
        
        
        }
    }
}