using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb9___TicTacToe
{
    class UI
    {
        Runtime runtime = new Runtime();
        Grid grid = new Grid();
        Node node = new Node();

        public void Start()
        {
            Console.WriteLine("Player:");
            int inputPlayer = int.Parse(Console.ReadLine());

            var mainloop = true;

            while (mainloop)
            {


                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        runtime.PlayerAction(1, inputPlayer);
                        break;
                    case ConsoleKey.D2:
                        runtime.PlayerAction(2, inputPlayer);
                        break;
                    case ConsoleKey.D3:
                        runtime.PlayerAction(3, inputPlayer);
                        break;
                    case ConsoleKey.D4:
                        runtime.PlayerAction(4, inputPlayer);
                        break;
                    case ConsoleKey.D5:
                        runtime.PlayerAction(5, inputPlayer);
                        break;
                    case ConsoleKey.D6:
                        runtime.PlayerAction(6, inputPlayer);
                        break;
                    case ConsoleKey.D7:
                        runtime.PlayerAction(7, inputPlayer);
                        break;
                    case ConsoleKey.D8:
                        runtime.PlayerAction(8, inputPlayer);
                        break;
                    case ConsoleKey.D9:
                        runtime.PlayerAction(9, inputPlayer);
                        break;

                }
            }
        }

       

    }
}
