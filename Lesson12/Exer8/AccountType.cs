using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer8
{
    public abstract class AccountType
    {
        public abstract void CalculateInterest(int months);
        public abstract void CalculateInterest(int months, string customers);


        public string Customer { get; set; }   //string "0" = individuals.     string "1" = companies
     
        public decimal balance { get; set; }
        public decimal interestRate { get; set; }
        public decimal interest { get; set; }
    }
}
