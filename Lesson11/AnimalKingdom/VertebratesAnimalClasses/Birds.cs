using AnimalKingdom.AnimalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.VertebratesAnimalClasses
{
    class Birds : Vertebrates, IAnimalActions
    {
        public Birds()
        {
            base.Name = "Bird";
        }
        public void Breathe()
        {
            // through their beaks
        }

        public void Feed()
        {
            // through their beaks
        }

        public void Movement()
        {
           // flying in the air with their feathers
        }

        public void Reproduce()
        {
            throw new NotImplementedException();
        }

        public void Survive()
        {
            throw new NotImplementedException();
        }

        public void MakeSound()
        {
            // bird sound
        }

        public object Beaks { get; set; }
        public object Wings { get; set; }
        public object Feathers { get; set; }
    }
}
