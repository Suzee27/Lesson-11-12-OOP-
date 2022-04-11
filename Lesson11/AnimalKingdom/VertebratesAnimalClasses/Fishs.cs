using AnimalKingdom.AnimalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.VertebratesAnimalClasses
{
    class Fishs : Vertebrates, IAnimalActions
    {
        public Fishs()
        {
            base.Name = "Fish";
        }

        public void Breathe()
        {
            // throuh their Gills
        }

        public void Feed()
        {
            // can swallow
        }

        public void Movement()
        {
            // swim
        }

        public void Reproduce()
        {
            // Asexual reproduction
        }

        public void Survive()
        {
            // stay alive
        }

        public void MakeSound()
        {
            // makes fish sound
        }

        public object Scales { get; set; }
        public object Gills { get; set; }
    }
}
