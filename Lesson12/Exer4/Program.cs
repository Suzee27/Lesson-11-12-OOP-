using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4
{
    class Program
    {
        static void Main(string[] args)
        {
            Workers[] workers = new Workers[]
            {
                new Workers(9),
                new Workers(89),
                new Workers(12),
                new Workers(2),
                new Workers(7),
                new Workers(23),
                new Workers(1),
                new Workers(9),
                new Workers(11),
                new Workers(21)
            };

            // sorting array in descending order
            Array.Sort(workers, (a, b) => b.CompareTo(a));
        
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.Salary);
            }
            Console.ReadKey();
        }
    }
}
