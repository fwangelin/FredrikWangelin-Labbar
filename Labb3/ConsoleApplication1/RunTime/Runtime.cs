using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Runtime
    {
        public void Start()
        {
            EventManager manager = new EventManager();
            
            bool loop = true;

            while (loop)
            {
                Console.Clear();
                MenuGraphics.MainMenu();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        manager.PrintConcertInfoToConsole();
                        Console.WriteLine();
                        Console.WriteLine("*****************************************************************");
                        manager.BookConcert();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        manager.PrintFestivalInfoToConsole();
                        Console.WriteLine();
                        Console.WriteLine("*****************************************************************");
                        manager.BookFestivals();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        manager.PrintMoviesInfoToConsole();
                        Console.WriteLine();
                        Console.WriteLine("*****************************************************************");
                        manager.BookMovies();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("*****************************************************************");
                        manager.PrintBookingsToConsole();
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
