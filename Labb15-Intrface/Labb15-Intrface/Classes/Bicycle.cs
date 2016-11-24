using Labb15_Intrface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15_Intrface.Classes
{
    class Bicycle : IVehicle
    {
        public void Lock()
        {
            Console.WriteLine("Locking bike");
        }

        public void Start()
        {
            Console.WriteLine("Pedalling away..");
        }

        public void Stop()
        {
            Console.WriteLine("front and back brakes locking. You have stopped the bike");
        }

        public void Unlock()
        {
            Console.WriteLine("fiddeling with the keys, finally getting the lock open..");
        }
    }
}
