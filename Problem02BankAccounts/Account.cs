using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem02BankAccounts
{
    public abstract class Account
    {
        private Customer customerName;
        private decimal balance;
        private decimal interestRate;

        public Customer CustomerName
        {
            get { return this.customerName; }
            set { this.customerName = value; }
        }
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }

        }
        public Account(Customer customerName, decimal balance, decimal interestRate)
        {
            this.CustomerName = customerName;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public void Deposit(decimal money)  // for all accounts
        {
            if (money <= 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.Balance += money;
        }

        public abstract decimal CalculateInterestAmount(int months);

    }
}