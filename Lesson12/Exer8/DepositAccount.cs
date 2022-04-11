using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer8
{
    class DepositAccount: AccountType, IDeposit, IWithdraw
    {
        public DepositAccount()
        {
            CalculateInterest(5);
        }

        public override void CalculateInterest(int months)
        {
            if (balance>0 && balance<1000)
            {
                interestRate = 0;
                interest = months * interestRate;
            }
            else
            {
                interest = months * interestRate;
            }
        }

        public override void CalculateInterest(int months, string customers)
        {
            //do nothing
        }

        public void DepositMoney()
        {
            // deposit naira
        }

        public void WithdrawMoney()
        {
            // withdraw dollar
        }
    }
}
