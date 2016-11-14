using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9TicTacToe
{
	interface IGrid
	{
		Node[,] Grid { get; }
		
		bool PlaceMarker(int positionX, int positionY, Player player);
	}
}
