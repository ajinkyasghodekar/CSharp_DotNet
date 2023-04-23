using System;

namespace MyBankAccountApp
{
    class BankAccount
    {

        public BankAccount(string name, decimal InitialBalance)
        {
            this.Owner = name;
            this.Balance = InitialBalance;
        }
        public string Number { get; }
        public string Owner { get; set; }

        public decimal Balance { get; set; }

        public void Deposit (decimal ammount, DateTime data, string note)
        {

        }

        public void Withdrawl(decimal ammount, DateTime data, string note)
        {

        }
    }
}