using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb9___TicTacToe
{
    class Grid : InterfaceGrid
    {

        Node[,] node = new Node[,]
        {
            {new Node(), new Node(), new Node()},
            {new Node(), new Node(), new Node()},
            {new Node(), new Node(), new Node()}
        };
    

        public void PlaceMarker(int positionX, int positionY, int player)
        {
            Console.WriteLine(player);
           
            if (node[positionX, positionY].Player == 0) { node[positionX, positionY].Player = player; }

            //Console.WriteLine(node[positionX, positionY].Player);
            //Console.ReadLine();
            Console.Clear();
                Console.WriteLine("     |     |      ");
                Console.WriteLine(" {0}   | {1}   | {2}  ", node[0, 0].Player, node[0, 1].Player, node[0,2].Player);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine(" {0}   | {1}   | {2}  ", node[1, 0].Player, node[1, 1].Player, node[1, 2].Player);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine(" {0}   | {1}   | {2}  ", node[2, 0].Player, node[2, 1].Player, node[2, 2].Player);
                Console.WriteLine("     |     |      ");

 
        }


    }

}
