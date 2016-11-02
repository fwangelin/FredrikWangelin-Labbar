using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Interface
{
    class GameEngine
    {
        UI userInterface = new UI();

        public void Start()
        {
            var mainLoop = true;

            while (mainLoop)
            {
                Console.Clear();
                Console.WriteLine("Welcome, you have reached the gates of the haunted house, do you dare to enter?");
                Console.WriteLine();
                Console.WriteLine("*Choose Y/N if you want to enter the front yard of the haunted house*");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.Y:
                        YardEngine();
                        break;
                    case ConsoleKey.N:
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        mainLoop = false;
                        break;
                }
            }
        }

        public void YardEngine()
        {
            var yardLoop = true;

            while (yardLoop)
            {
                Console.Clear();
                Console.WriteLine("Use your keyboard arrows to move around, Down key lets you leave your current enviroment.");
                Console.WriteLine();
                userInterface.Yards();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        Console.WriteLine("Wow, that white dog crap is really flying");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.RightArrow:
                        userInterface.Humans();
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        Console.WriteLine("\n*Press enter to open Mansion door*");
                        Console.ReadKey(true);
                        RoomEngine();
                        break;

                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        Console.WriteLine("Running out of the gates back home to your mama...");
                        Console.Read();
                        yardLoop = false;
                        break;
                }
            }
        }

        public void RoomEngine()
        {
            var roomLoop = true;

            while (roomLoop)
            {
                Console.Clear();
                Console.WriteLine("Use your keyboard arrows to move around, Down key lets you leave your current enviroment.");
                Console.WriteLine();
                userInterface.Rooms();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        Console.WriteLine("Yup, That's a painting of God alright..");
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        Console.WriteLine("*Press any key to open cellar door...*");
                        Console.ReadKey(true);
                        userInterface.Animals();
                        Console.WriteLine("Nice job, you just released the fucking Kraken, you are soooo dead...");
                        Console.ReadKey(true);
                        userInterface.LoseGame();
                        break;

                    case ConsoleKey.LeftArrow:
                        userInterface.Ghosts();
                        userInterface.AnswersFromGhost();
                        break;

                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        Console.WriteLine("Going back to the yard...");
                        Console.Read();
                        roomLoop = false;
                        break;
                }

            }
        }





    }
}
