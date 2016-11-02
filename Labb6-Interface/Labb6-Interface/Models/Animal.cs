using Labb6_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Interface.Classes
{
    class Animal : INonPlayerCharacter
    {
        public string Appearence { get; set; } = "Smelling of old sea and looking pretty intimidating with his massive jaws";

        public string Movement { get; set; } = "Flapping his 8 arms and biting furiously with his jaws";

        public string Speak()
        {
            return "ROOOOAAAAAAAAARRRR";
        }

    }
}
