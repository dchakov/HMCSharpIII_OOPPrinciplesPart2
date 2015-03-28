using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02BankAccounts
{
    public class DepositAccount:Account,IWithdrawmoney
    {
       public DepositAccount(Customer customerName,decimal balance,decimal interestRate)
           :base(customerName,balance,interestRate)
        {

        }
        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Balance >= 1000)
            {
                return (this.Balance*(this.InterestRate/100))*months;
            }
            else return 0;
        }

        public void Withdraw(decimal money)
        {
            this.Balance -=money;
        }
    }
}
