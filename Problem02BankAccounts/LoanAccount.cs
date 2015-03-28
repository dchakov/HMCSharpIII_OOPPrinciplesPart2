using System;

namespace Problem02BankAccounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customerName, decimal balance, decimal interestRate)
            : base(customerName, balance, interestRate)
        {

        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.CustomerName is Individuals)
            {
                if (months <= 3)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * (this.InterestRate / 100)) * (months-3);
                }
            }
            else
            {
                if (months <= 2)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * (this.InterestRate / 100)) * (months-2);
                }
            }
        }
    }
}
