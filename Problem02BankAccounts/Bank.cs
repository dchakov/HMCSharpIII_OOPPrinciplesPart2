using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02BankAccounts
{
    public class Bank
    {
        
        private List<Account> listAccounts;
              
        public List<Account> ListAccounts
        {
            get { return this.listAccounts; }
        }
        public Bank()
        {
            this.listAccounts = new List<Account>();
        }
        public void AddAccount(Account newAccount)
        {
            listAccounts.Add(newAccount);
        }
        public void RemoveAccount(Account exitingAccount)
        {
            listAccounts.Remove(exitingAccount);
        }
    }
}
