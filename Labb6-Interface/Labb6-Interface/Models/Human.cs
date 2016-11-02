using Labb6_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Interface.Classes
{
    class Human : INonPlayerCharacter
    {
        public string Appearence { get; set; } = "Ugly and broken";

        public string Movement { get; set; } = "Nervously biting fingernails";

        public string Speak()
        {
            return "Hello I'm a destroyed man. I have lost my mother to the giljoutine and now I have nothing left.\nI wish I was dead, can you help me?";

        }
    }
}
