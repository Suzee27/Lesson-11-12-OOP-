using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer6
{
    class Kitten: Animals
    {
        public Kitten(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string MakeSound()
        {
            Console.WriteLine("meow meow");
            return "";
        }
    }
}
