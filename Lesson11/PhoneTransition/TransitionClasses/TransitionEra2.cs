using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneTransition.TransitionClasses
{
    class TransitionEra2: TransitionEra1
    {

        public TransitionEra2()
        {

        }

        void SnapPictures()
        {
            // use camera to take photos of self
        }

        void MakeVideos()
        {
           // make videos of an event
        }

        public override void Call()
        {
            base.Call();
            // make video calls to friends
        }

        public object Camera { get; set; }
        public string MMS { get; set; }

        public object Video { get; set; }

    }
}
