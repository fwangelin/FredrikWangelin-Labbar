using Labb15_Intrface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15_Intrface.Classes
{
    class Car : IVehicle
    {
        public void Lock()
        {
            Console.WriteLine("Locking car");
        }

        public void Start()
        {
            Console.WriteLine("Enginge started, don't forget to pick up milk");
        }

        public void Stop()
        {
            Console.WriteLine("Shutting down engine");
        }

        public void Unlock()
        {
            Console.WriteLine("car unlocked");
        }
    }
}
