using Labb6_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Interface.Models
{
    class Ghost : INonPlayerCharacter
    {
        public string Appearence { get; set; } = "Pale and looking pretty dead";

        public string Movement { get; set; } = "Hoovering above the floor ghost style";

        public string Speak()
        {
            return "Booo Wendy Testaburger, Boo-oooo I'm looking for my son. Booo-ooooooo, have you seen him?";
        }
    }
}
