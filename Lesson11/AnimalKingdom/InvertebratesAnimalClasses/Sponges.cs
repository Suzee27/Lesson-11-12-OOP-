using AnimalKingdom.AnimalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.InvertebratesAnimalClasses
{
    class Sponges : Invertebrates, IAnimalActions
    {
        public Sponges()
        {
            base.Name = "sponges";
            this.TypeOfSponges = "yellow tube sponge";
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

        public object Pores { get; set; }
        public string TypeOfSponges { get; set; }
    }
}
