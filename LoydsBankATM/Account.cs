using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoydsBankATM
{
    public class Account
    {
        private int accountId;
        private string accountType;
        private string accountName;
        private float accountBalance;

        public Account(int accountId, string accountType, string accountName, float accountBalance)
        {
            this.accountId = accountId;
            this.accountType = accountType;
            this.accountName = accountName;
            this.accountBalance = accountBalance;
        }

        public int GetAccountID() { return accountId; }
        public string GetAccountType() { return accountType; }
        public string GetAccountName() { return accountName; }
        public float GetAccountBalance() { return accountBalance; }

    }
}
