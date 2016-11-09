using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_Store_App
{
    class Client
    {
        UI userInterface = new UI();

        public void Start()
        {
            var mainLoop = true;

            while (mainLoop)
            {
                userInterface.MainMenu();
                var input = Console.ReadKey(true).Key;

                switch(input)
                {
                    case ConsoleKey.D1:
                        // Show items in stock
                        break;
                    case ConsoleKey.D2:
                        // Adding items
                        break;
                    case ConsoleKey.D3:
                        // Display customer shoppingbag
                        break;
                    case ConsoleKey.D4:
                        mainLoop = false;
                        break;
                }
            }
        }
    }
}
