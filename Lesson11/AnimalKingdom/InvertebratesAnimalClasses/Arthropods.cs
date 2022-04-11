using AnimalKingdom.AnimalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.InvertebratesAnimalClasses
{
    class Arthropods : Invertebrates, IAnimalActions
    {
        public Arthropods()
        {
            base.Name = "arthropods";
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
        }
    }
}
