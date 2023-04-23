using System;

namespace MyBankAccountApp
{
    class BankAccount
    {

        public BankAccount(string name, decimal InitialBalance)
        {
            // Step I
            this.Owner = name;

            // Step II
            this.Number = AccountNumber.ToString();
            AccountNumber++;

            // Step III
            Deposit(InitialBalance, DateTime.Now, "Rupees");

        }
        public string Number { get; }
        public string Owner { get; set; }

        public decimal Balance { 
            get
            {
                decimal balance = 0;
                foreach (var item in AllTransactions)
                {
                    balance = balance + item.Amount;
                }
                return balance;
            }
        }

        private static int AccountNumber = 1234567890;

        private List<Transactions> AllTransactions= new List<Transactions> ();

        // Deposite Operations
        public void Deposit (decimal amount, DateTime date, string note)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount deposite to be made positive");
            }
            
            var Deposit = new Transactions(amount, date, note);
            AllTransactions.Add(Deposit);
        }

        //Withdrawl operations
        public void Withdrawl(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be positive");
            }

            if(Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient balance in account");
            }

            var Withdrawl = new Transactions(-amount, date, note);
            AllTransactions.Add(Withdrawl);
        }

        // Generate a report for account history
        public string getAccountHistory()
        {
            var report = new System.Text.StringBuilder();
            decimal balance = 0;
            Console.WriteLine("Amount \t\t\t Notes \t\t Date");
            foreach (var item in AllTransactions)
            {
                balance = balance + item.Amount;
                report.AppendLine($"{item.Amount}\t\t\t{item.Notes}\t\t{item.Date}");
            }
            return report.ToString();
        }
    }
}