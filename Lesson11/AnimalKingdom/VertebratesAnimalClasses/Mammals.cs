using AnimalKingdom.AnimalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.VertebratesAnimalClasses
{
    class Mammals : Vertebrates, IAnimalActions
    {
        public void Breathe()
        {
            // through respiratory organ
        }

        public void Feed()
        {
            // through their mouths
        }

        public virtual void Movement()
        {
            // walk on four limbs
        }

        public void Reproduce()
        {
            //sexual reproduction
        }

        public virtual void Survive()
        {
            // staying alive
            // hunting down their prey
        }

        public virtual void MakeSound()
        {
            // it depends
        }

        public object limbs { get; set; }
    }
}
