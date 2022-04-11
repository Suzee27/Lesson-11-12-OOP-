using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneTransition.TransitionClasses
{
    class TransitionEra3: TransitionEra2
    {
        public TransitionEra3()
        {

        }

        void SendEmails()
        {
            // compose and send official emails
            // apply for jobs through emails
        }

        void PlayGames()
        {
            // play a video game onyour phone
        }

        void SendMessageOnSocialMedia()
        {
            // use whatsapp, twitter
            SendTextMessages();
        }

        public string Emials { get; set; }
        public object Games { get; set; }
        public object SocialMedia { get; set; }
    }
}
