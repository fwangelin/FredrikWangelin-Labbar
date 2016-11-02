using Labb6_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Interface.EnviromentModels
{
    class Room : IEnviroment
    {
        public string EnviromentObservation()
        {
            return "You have entered the Mansion.\n\n"+
                "\nA scent of mold and death has struck the once victorian styled room.\nA living person has not been here for hundreds of years.\n\n"+
                "To your right you can see a big cellar door. \nTo your left you can see a what looks like a person, "+
                "\nif you look up, you can see a painting of GOD";
        }
    }
}
