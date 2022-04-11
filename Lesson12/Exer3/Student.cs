using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer3
{
    class Student : IComparable<Student>
    {
        public Student(int mark)
        {
            this.Mark = mark;
        }

        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return Mark.CompareTo(other.Mark);
        }

        public void GenerateMark()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Mark = rnd.Next(100);

            }
        }
        public int Mark { get; set; }
    }
}
