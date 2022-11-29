using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoydsBankATM;

namespace LoydsBankATM
{
    public class Account
    {
        private int accountNumber;
        private string accountHolderName;
        private string accountType;
        private int balance = 0;
        private int overDraftLimited;
        private List<Transactions> transactions = new List<Transactions>();

        public Account(int accNumber, string accHolderName,int balance,string accType, int odLimited)
        {
            this.accountNumber = accNumber;
            this.accountHolderName = accHolderName;
            this.accountType = accType;
            this.balance = balance;
            this.overDraftLimited = odLimited;
        }

        public Account(int accountNumber, string accountHolderName, int balance, int overDraftLimited, List<Transactions> transactions)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balance = balance;
            this.overDraftLimited = overDraftLimited;
            this.transactions = transactions;
        }

        public Account(int accNumber, string accHolderName, int odLimited)
        {
            this.accountNumber = accNumber;
            this.accountHolderName = accHolderName;
            this.overDraftLimited = odLimited;
        }
        public Account()
        {
           
        }

        public void deposite(int amount)
        {
            int currentBalance = 0;
            int balanceAfter = 0;
            this.balance = currentBalance;

            this.balance += amount;
            transactions.Add(new Transactions("Deposite", amount, currentBalance, balanceAfter));
        }

        public int viewBalance()
        {
            return this.balance;
        }

        public int withdraw(int amount)
        {
            int currentBalance = 0;
            int balanceAfter = 0;
            this.balance = currentBalance;
            if (this.balance + this.overDraftLimited >= amount)
            {
                this.balance = this.balance - amount;
                this.balance = balanceAfter;
               
                return balanceAfter;
            }
            else
            {
                return currentBalance;
            }

        }

        public string creatstatment()
        {
            string statment = this.accountHolderName + " , " + this.accountNumber + " , " + this.balance + " , " + this.overDraftLimited;
            return statment;
        }
        public List<Transactions> GetTransactions()
        {
            return transactions;
        }

        public int GetAccountNumber()
        {
            return this.accountNumber;
        }
        public int GetOverDraft()
        {
            return this.overDraftLimited;
        }

        public string GetAccountHolderName()
        {
            return accountHolderName;
        }
        
    }
}
