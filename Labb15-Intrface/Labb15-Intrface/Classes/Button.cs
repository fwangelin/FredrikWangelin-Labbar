using Labb15_Intrface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15_Intrface.Classes
{
    class Button : IPushable
    {
        public void Push()
        {
            Console.WriteLine("Boulder pushed");
        }
    }
}
