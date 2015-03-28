using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02BankAccounts
{
    public class MortgageAccount:Account
    {
        public MortgageAccount(Customer customerName,decimal balance,decimal interestRate)
           :base(customerName,balance,interestRate)
        {

        }
        public override decimal CalculateInterestAmount(int months)
        {
            if (this.CustomerName is Individuals)
            {
                if (months > 6)
                {
                    return (months-6) * ((this.InterestRate / 100 * this.Balance));  
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (months > 12)
                {
                    return (months - 12) * (this.InterestRate / 100 * this.Balance) + 
                            12 * (this.InterestRate / 200 * this.Balance); 
                }
                else
                {
                    return months * (this.InterestRate / 200 * this.Balance);
                }
            }

        }
    }
}
