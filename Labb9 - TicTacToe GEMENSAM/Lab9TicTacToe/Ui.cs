using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9TicTacToe
{
	class Ui
	{

		Player player = Player.X;

		public PlayBoard playboard = new PlayBoard();


		public void MainMenu()
		{
			Console.Clear();
			Console.WriteLine("WELCOME! Hope you have fun playing");
			Console.WriteLine("Press a button to continue to the gameboard");
			Console.ReadKey(true);
			bool isMainMenu = true;
			

			while (isMainMenu)
			{
				GridGraphics();
				Console.WriteLine();
				Console.WriteLine("Press where you want to place your marker");

				try
				{
					var input = int.Parse(Console.ReadLine());

					input -= 1;

					if (playboard.PlaceMarker(input % 3, input / 3, player))
					{
						if (player == Player.X)
						{
							player = Player.O;
						}
						else
						{
							player = Player.X;
						}
					}
				}
				catch(Exception)
				{
					Console.WriteLine();
					Console.WriteLine("ERROR!, You must pick a value between 1 - 9");
					Console.ReadLine();
				}

				if (playboard.Checkwin())
				{
					Console.WriteLine();
					Console.WriteLine("WIN WIN WIN");
					Console.WriteLine("Press any key to try again!");
					playboard.ResetPlayfield();
					Console.ReadKey(true);
					isMainMenu = false;
				}

				if (playboard.GameOver())
				{
					GameOverGraphics();
					isMainMenu = false;
				}
			}
			
		}

		public void StartTheGame()
		{
			bool IsMenuTrue = true;

			while (IsMenuTrue)
			{
				Console.Clear();
				Console.WriteLine("1. Start the game");
				Console.WriteLine("2. Exit the game");

				var input = Console.ReadKey(true).Key;

				switch (input)
				{
					case ConsoleKey.D1:
						MainMenu();
						break;
					case ConsoleKey.D2:
						IsMenuTrue = false;
						break;

				}
			}
		}

		public void GridGraphics()
		{
			Console.Clear();
			Console.WriteLine("It is Player {0}'s turn", player);
			Console.WriteLine("     |     |      ");
			Console.WriteLine("  {0}  |  {1}  |  {2}", playboard.Grid[0, 0].Player, playboard.Grid[1, 0].Player, playboard.Grid[2, 0].Player);
			Console.WriteLine("_____|_____|_____ ");
			Console.WriteLine("     |     |      ");
			Console.WriteLine("  {0}  |  {1}  |  {2}", playboard.Grid[0, 1].Player, playboard.Grid[1, 1].Player, playboard.Grid[2, 1].Player);
			Console.WriteLine("_____|_____|_____ ");
			Console.WriteLine("     |     |      ");
			Console.WriteLine("  {0}  |  {1}  |  {2}", playboard.Grid[0, 2].Player, playboard.Grid[1, 2].Player, playboard.Grid[2, 2].Player);
			Console.WriteLine("     |     |      ");

		}

		public void GameOverGraphics()
		{
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(@"  __  __  __ __ ___    __   _   _  ___ ___  ".PadLeft(80));
			Console.WriteLine(@" / _]/  \|  V  | __|  /__\ | \ / || __| _ \ ".PadLeft(80));
			Console.WriteLine(@"| [/\ /\ | \_/ | _|  | \/ |`\ V /'| _|| v / ".PadLeft(80));
			Console.WriteLine(@" \__/_||_|_| |_|___|  \__/   \_/  |___|_|_\ ".PadLeft(80));
			Console.WriteLine();
			Console.WriteLine("Thanks for playing!".PadLeft(67));
		}

	}
}






