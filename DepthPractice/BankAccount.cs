using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace DepthPractice
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owener { get; set; }

        public decimal Balance
        {

            get
            { 
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
}


        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit can't be Negative");
            }

            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawl(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Ammount Withdraw must be positive");
            }

            if (Balance - amount < 0)
            {
                throw new ArgumentOutOfRangeException("Not succicient fund to withdraw");
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owener = name;
           
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        }

        private List<Transaction> allTransactions = new List<Transaction>();
    }
}