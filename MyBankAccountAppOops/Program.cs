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
        
        }
    }
}