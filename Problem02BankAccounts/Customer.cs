using System;

namespace Problem02BankAccounts
{
    public abstract class Customer
    {
        private string customerName;

        public string CustomerName
        {
            get { return this.customerName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Cannot be null or empty");
                }
                this.customerName = value;
            }
        }
        public Customer(string customerName)
        {
            this.CustomerName = customerName;
        }
    }
}
