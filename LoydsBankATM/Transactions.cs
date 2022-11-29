using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoydsBankATM
{
    public class Transactions
    {
        private string type;
        private float amount;
        private float balanceBefore;
        private float balanceAfter;

        public Transactions(string type, float amount, float balanceBefore, float balanceAfter)
        {
            this.type = type;
            this.amount = amount;
            this.balanceBefore = balanceBefore;
            this.balanceAfter = balanceAfter;
        }

        public string getType() { return type; }
        public float getAmount() { return amount; }
        public float getBalanceBefore() { return balanceBefore; }
        public float getBalanceAfter() { return balanceAfter; }
    }
}
