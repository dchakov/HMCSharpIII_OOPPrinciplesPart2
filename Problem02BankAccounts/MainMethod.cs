using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02BankAccounts
{
    class MainMethod
    {
        static void Main()
        {
            Bank unicredit = new Bank();
            
            DepositAccount ivanIvanov = new DepositAccount(new Individuals("Ivan Ivanov"), 1000m, 2.00m);
            MortgageAccount dikToshev = new MortgageAccount(new Individuals("Dik Toshev"), 1000m, 1.00m);
            MortgageAccount nikPopov = new MortgageAccount(new Individuals("Nik Popov"), 1000m, 2.00m);
            MortgageAccount dikToshev1 = new MortgageAccount(new Companies("Dik Toshev-ET"), 1000m, 1.00m);
            MortgageAccount nikPopov1 = new MortgageAccount(new Companies("Nik Popov-ET"), 1000m, 1.00m);
            LoanAccount dikToshev2 = new LoanAccount(new Individuals("Dik Toshev-loan"), 1000m, 1.00m);
            LoanAccount nikPopov2 = new LoanAccount(new Companies("Nik Popov-ET-loan"), 1000m, 1.00m);

            
            Console.WriteLine(ivanIvanov.CalculateInterestAmount(2));
            Console.WriteLine(dikToshev.CalculateInterestAmount(5));
            Console.WriteLine(dikToshev.CalculateInterestAmount(7));
            Console.WriteLine(dikToshev1.CalculateInterestAmount(10));
            Console.WriteLine(dikToshev1.CalculateInterestAmount(13));
            Console.WriteLine(dikToshev2.CalculateInterestAmount(3));
            Console.WriteLine(nikPopov2.CalculateInterestAmount(3));

            unicredit.AddAccount(ivanIvanov);
            dikToshev2.Deposit(100);
            
        }
    }
}
