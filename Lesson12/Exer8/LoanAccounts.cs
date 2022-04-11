using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer8
{
    class LoanAccounts : AccountType, IDeposit
    {


        public override void CalculateInterest(int months)
        {
            interestRate = 0;
            interest = months * interestRate;
        }

        public override void CalculateInterest(int months, string customers)
        {
            base.Customer = customers;
            if (months == 1 && months <= 3 && Customer == "0")
            {
                CalculateInterest(months);
            }
            else if (months == 1 && months <= 2 && Customer == "1")
            {
                CalculateInterest(months);
            }
            else
            {
                interest = months * interestRate;
            }
        }

        public void DepositMoney()
        {
            //deposit pounds
        }

        
    }
}
