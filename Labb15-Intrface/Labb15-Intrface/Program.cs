using Labb15_Intrface.Classes;
using Labb15_Intrface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15_Intrface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            

            var boulder = new Boulder();
            IPushable button = new Button();
            IVehicle car = new Car();
            var bike = new Bicycle();
            var spaceship = new SpaceShip();


            boulder.Push();
            button.Push();
            spaceship.Unlock();
            spaceship.Start();
            spaceship.Stop();
            spaceship.Lock();

        }
    }
}
