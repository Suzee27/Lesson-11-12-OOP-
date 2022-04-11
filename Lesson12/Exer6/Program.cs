using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer6
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals();
            Dog dog = new Dog("mask", 4);
            Frog frog = new Frog("alix", 2);
            Cat cat = new Cat("pet", 1);
            Kitten kitten = new Kitten("boost", 2);
            Tomcat tomcat = new Tomcat("tommy", 3);

            Animals[] animal = new Animals [5];
            animal[0] = dog;
            animal[1] = frog;
            animal[2] = cat;
            animal[3] = kitten;
            animal[4] = tomcat;

            animals.DisplayAnimals();

            Console.WriteLine("The name of this dog is {0] and is {1} years old, makes sound{2}", dog.name, dog.age, dog.MakeSound());
            Console.WriteLine("The name of this frog is {0] and is {1} years old, makes sound{2}", frog.name, frog.age, frog.MakeSound());
            Console.WriteLine("The name of this cat is {0] and is {1} years old, makes sound{2}", cat.name, cat.age, cat.MakeSound());
            Console.WriteLine("The name of this kitten is {0] and is {1} years old, makes sound{2}", kitten.name, kitten.age, kitten.MakeSound());
            Console.WriteLine("The name of this tomcat is {0] and is {1} years old, makes sound{2}", tomcat.name, tomcat.age, tomcat.MakeSound());

        }
    }
}
