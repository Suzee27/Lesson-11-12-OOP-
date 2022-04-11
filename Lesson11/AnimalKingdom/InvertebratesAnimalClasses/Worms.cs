using AnimalKingdom.AnimalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.InvertebratesAnimalClasses
{
    class Worms : Invertebrates, IAnimalActions
    {
        public Worms()
        {
            base.Name = "worms";
        }
        public void Breathe()
        {
           //
        }

        public void Feed()
        {
            //
        }

        public void MakeSound()
        {
            //
        }

        public void Movement()
        {
            //
        }

        public void Reproduce()
        {
           //
        }

        public void Survive()
        {
           //
        }
    }
}
