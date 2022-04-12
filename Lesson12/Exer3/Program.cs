using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student(9),
                new Student(89),
                new Student(12),
                new Student(2),
                new Student(7),
                new Student(23),
                new Student(1),
                new Student(9),
                new Student(11),
                new Student(21)
            };

            Array.Sort(students);

            foreach (var student in students)
            {
                Console.WriteLine(student.Mark);
            }
            Console.ReadKey();
        }
    }
}
