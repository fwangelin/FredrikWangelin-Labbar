using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9TicTacToe
{
	enum Player
	{
		X = 1,
		O
	};

	class Node
	{	
		public bool IsTaken { get; set; }
		public Player Player { get; set; }
	}
}
