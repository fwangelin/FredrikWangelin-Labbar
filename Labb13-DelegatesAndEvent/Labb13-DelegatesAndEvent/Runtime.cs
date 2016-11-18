using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb13_DelegatesAndEvent.Delegate;

namespace Labb13_DelegatesAndEvent
{
    class Runtime
    {
        public void Start()
        {
            ListManager manager = new ListManager();
            var mainLoop = true;

            while (mainLoop)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine();
                Console.WriteLine("1. Adding stuff to The list");
                Console.WriteLine("2. Filters");
                Console.WriteLine("3. Show List");
                Console.WriteLine("4. Quit");
                var switchMenu = Console.ReadKey(true).Key;

                switch (switchMenu)
                {
                    case ConsoleKey.D1:
                        manager.CreateObject();
                        break;
                    case ConsoleKey.D2:
                        manager.FilterMethod();
                        break;
                    case ConsoleKey.D3:
                        manager.PrintToConsole();
                        break;
                    case ConsoleKey.D4:
                        mainLoop = false;
                        break;
                }
            }
            
        }
    }
}
