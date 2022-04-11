using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2
{
   public class Worker: Human
    {
        public Worker()
        {
            this.Wage = Wage;
        }

        public Worker(int hours, decimal wage)
        {
            Wage = wage;
            HoursWorked = hours;
        }
        private decimal wage;

        public decimal Wage
        {
            get { return wage; }
            set { wage = value; }
        }

        private int hoursWorked;

        public int HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        public decimal CalculateHourlyWage(decimal wage,int hours)
        {
            decimal WorkersHourlyPay = wage * hours;
            return WorkersHourlyPay;
        }
    }
}
