using Labb15_Intrface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15_Intrface.Classes
{
    class SpaceShip : IVehicle
    {
        public void Lock()
        {
            Console.WriteLine("Locking Spaceship");
        }

        public void Start()
        {
            Console.WriteLine("3...2...1... Enginge Starting, good luck out there...");
        }

        public void Stop()
        {
            Console.WriteLine("Shutting down engines");
        }

        public void Unlock()
        {
            Console.WriteLine("Spaceship unlocked");
        }
    }
}
