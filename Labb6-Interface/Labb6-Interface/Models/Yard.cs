using Labb6_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Interface.EnviromentModels
{
    class Yard : IEnviroment
    {
        public string EnviromentObservation()
        {
            return "You have entered the Yard\n\n"+
                "\nThe yard has a big garden that you can see was once beautiful and full of animals.\n" +
                "It now appears as if a reaper went thru and killed it all.\nThe smell of death is vivid\n\n" +
                "To your right you see a person, \nto your left a big door to a Mansion,\n"+
                "If you look up, you can see a flying white dog crap";

        }
    }
}
