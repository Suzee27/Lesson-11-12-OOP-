using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer6
{
   public class Animals
    {
        public Animals()
        {

        }
        public virtual string MakeSound()
        {
            Console.WriteLine("make a sound");
            return "";
        }

        public void DisplayAnimals()
        {
            Console.WriteLine("The different animals are;");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(animal[i]);
            }
        }

        public Animals[] animal { get; set; }
        public int age { get; set; }
        public string name { get; set; }
        public int gender { get; set; }

    }
}
