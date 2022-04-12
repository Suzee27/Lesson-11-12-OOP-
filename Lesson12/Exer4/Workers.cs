using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4
{
    class Workers: IComparable<Workers>
    {
        public Workers(int salary)
        {
            this.Salary = salary;

        }


        public int CompareTo(Workers other)
        {
            if (other == null) return 1;
            return Salary.CompareTo(other.Salary);
        }

       

        public int Salary { get; set; }
    }
}
