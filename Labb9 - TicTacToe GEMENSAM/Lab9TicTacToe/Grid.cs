using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9TicTacToe
{
	class PlayBoard : IGrid
	{

		int markerSpotTaken;

		public Node[,] Grid
		{
			get
			{
				return grid;
			}
		}

		Node[,] grid = new Node[,]
		{
			{new Node(), new Node(), new Node()},
			{new Node(), new Node(), new Node()},
			{new Node(), new Node(), new Node()}
		};


		public bool PlaceMarker(int positionX, int positionY, Player player)
		{


			if (grid[positionX, positionY].IsTaken == false)
				{
					grid[positionX, positionY].Player = player;
					grid[positionX, positionY].IsTaken = true;
				    markerSpotTaken++;
				return true;
		     	}	   
				else
				{
				    Console.WriteLine("FEL");
				    return false;
			    }


    		}

		public void ResetPlayfield()
		{
			for (int i = 0; i < Grid.GetLength(0); i++)
			{
				for (int j = 0; j < Grid.GetLength(1); j++)
				{
					Grid[i, j].Player = 0;
					Grid[i, j].IsTaken = false;
				}
			}
			markerSpotTaken = 0;
		}
		

		public bool GameOver()
		{
			if (markerSpotTaken == 9)
			{
				ResetPlayfield();
				return true;
			}
			return false;
			
		}

		#region TEST
		//public void CheckWinner()
		//{
		//	int playerOneCount = 0;
		//	int playerTwoCount = 0;

		//	for (int i = 0; i < Grid.GetLength(0); i++)
		//	{
		//		playerOneCount = 0;
		//		playerTwoCount = 0;
		//		for (int j = 0; j < grid.GetLength(1); j++)
		//		{
		//			if (Grid[i,j].Player == Player.X)
		//			{
		//				playerOneCount++;
		//			}
		//			if (Grid[i,j].Player == Player.O)
		//			{
		//				playerTwoCount++;
		//			}
		//			if (playerOneCount == 3)
		//			{
		//				Console.WriteLine("Player {0} WINS!", Player.X);
		//			}
		//			if (playerTwoCount == 3)
		//			{
		//				Console.WriteLine("Player {0} WINS!", Player.O);
		//			}
		//		}
		//	}
		//}
		#endregion

		public bool Checkwin()
		{

			//Player 1 Horizontal win
			if (grid[0, 0].Player == Player.X && grid[1, 0].Player == Player.X && grid[2, 0].Player == Player.X) return true;
			else if (grid[0, 1].Player == Player.X && grid[1, 1].Player == Player.X && grid[2, 1].Player == Player.X) return true;
			else if (grid[0, 2].Player == Player.X && grid[1, 2].Player == Player.X && grid[2, 2].Player == Player.X) return true;

			//Player 1 Diagonal win
			else if (grid[0, 0].Player == Player.X && grid[1, 1].Player == Player.X &&  grid[2, 2].Player == Player.X) return true;
			else if (grid[0, 2].Player == Player.X && grid[1, 1].Player == Player.X  && grid[2, 0].Player == Player.X ) return true;

			//Player 1 Vertical win
			else if (grid[0, 0].Player == Player.X && grid[0, 1].Player == Player.X && grid[0, 2].Player == Player.X) return true;
			else if (grid[1, 0].Player == Player.X && grid[1, 1].Player == Player.X && grid[1, 2].Player == Player.X) return true;
			else if (grid[2, 0].Player == Player.X && grid[2, 1].Player == Player.X && grid[2, 2].Player == Player.X) return true;


			//Player 2 Horizontal win
			if (grid[0, 0].Player == Player.O && grid[1, 0].Player == Player.O && grid[2, 0].Player == Player.O) return true;
			else if (grid[0, 1].Player == Player.O && grid[1, 1].Player == Player.O && grid[2, 1].Player == Player.O) return true;
			else if (grid[0, 2].Player == Player.O && grid[1, 2].Player == Player.O && grid[2, 2].Player == Player.O) return true;

			//Player 2 Diagonal win                                                                       
			else if (grid[0, 0].Player == Player.O && grid[1, 1].Player == Player.O && grid[2, 2].Player == Player.O) return true;
			else if (grid[0, 2].Player == Player.O && grid[1, 1].Player == Player.O && grid[2, 0].Player == Player.O) return true;


			//Player 2 Vertical win                                                                       
			else if (grid[0, 0].Player == Player.O && grid[0, 1].Player == Player.O && grid[0, 2].Player == Player.O) return true;
			else if (grid[1, 0].Player == Player.O && grid[1, 1].Player == Player.O && grid[1, 2].Player == Player.O) return true;
			else if (grid[2, 0].Player == Player.O && grid[2, 1].Player == Player.O && grid[2, 2].Player == Player.O) return true;

			
			else return false;
		}

	}

		}
		
	

	


