using System;

namespace MyBankAccountApp
{
    class BankAccount
    {

        public BankAccount(string name, decimal InitialBalance)
        {
            // Step I
            this.Owner = name;
            this.Balance = InitialBalance;

            // Step II
            this.Number = AccountNumber.ToString();
            AccountNumber++;
        }
        public string Number { get; }
        public string Owner { get; set; }

        public decimal Balance { get; set; }

        private static int AccountNumber = 1234567890;

        // Deposite Operations
        public void Deposit (decimal ammount, DateTime data, string note)
        {

        }

        //Withdrawl operations
        public void Withdrawl(decimal ammount, DateTime data, string note)
        {

        }
    }
}