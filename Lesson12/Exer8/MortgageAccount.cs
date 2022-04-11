using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer8
{
    class MortgageAccount : AccountType, IDeposit
    {
        public override void CalculateInterest(int months)
        {
            interestRate = 0;
            interest = months * interestRate;
        }

        public override void CalculateInterest(int months, string customers)
        {
            base.Customer = customers;
            if (months == 1 && months <= 6 && Customer == "0")
            {
                CalculateInterest(months);
            }
            else if (months == 1 && months <= 12 && Customer == "1")
            {
                interestRate = 1/2;
                interest = months * interestRate;
            }
            else
            {
                interest = months * interestRate;
            }
        }

        public void DepositMoney()
        {
            // deposit dollar
        }
    }
}
