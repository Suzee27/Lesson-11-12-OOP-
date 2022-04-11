using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.AnimalInterfaces
{
    interface IAnimalActions
    {
        void Reproduce();

        void Movement();

        void Breathe();

        void Feed();

        void Survive();

        void MakeSound();
    }
}
