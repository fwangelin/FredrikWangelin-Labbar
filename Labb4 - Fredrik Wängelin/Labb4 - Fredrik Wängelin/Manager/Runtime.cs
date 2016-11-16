using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4___Fredrik_Wängelin.Manager
{
    class Runtime
    {
        public void Start()
        {
            VehicleManager manager = new VehicleManager();

            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1. Nya Motorcyklar i Lager");
                Console.WriteLine("2. Begagnade Motorcyklar i lager");
                Console.WriteLine("3. Nya bilar i lager");
                Console.WriteLine("4. Begagnade bilar i lager");
                Console.WriteLine("5. Stäng ner och gå hem");

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        manager.PrintNewMotorCycleStock();
                        Console.WriteLine();
                        Console.WriteLine("*****************************************************************");
                        Console.Read();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        // Begagnade MC
                        Console.WriteLine();
                        Console.WriteLine("*****************************************************************");
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        // Nya bilar
                        Console.WriteLine();
                        Console.WriteLine("*****************************************************************");
                        
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("*****************************************************************");
                        // Beggade bilar
                        Console.WriteLine("*****************************************************************");
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        loop = false;
                        break;
                }

            }
        }
    }
}
