using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Interface.Interfaces
{
    interface INonPlayerCharacter
    {
        string Movement { get; set; }
        string Appearence { get; set; }
        string Speak();
        
    }
}
