using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb9___TicTacToe
{
    class Runtime
    {
        Grid grid = new Grid();
        Node node = new Node();

        public void PlayerAction(int input, int inputPlayer)
        {
            if (input == 1) { grid.PlaceMarker(0, 0, inputPlayer); }
            if (input == 2) { grid.PlaceMarker(0, 1, inputPlayer); }
            if (input == 3) { grid.PlaceMarker(0, 2, inputPlayer); }
            if (input == 4) { grid.PlaceMarker(1, 0, inputPlayer); }
            if (input == 5) { grid.PlaceMarker(1, 1, inputPlayer); }
            if (input == 6) { grid.PlaceMarker(1, 2, inputPlayer); }
            if (input == 7) { grid.PlaceMarker(2, 0, inputPlayer); }
            if (input == 8) { grid.PlaceMarker(2, 1, inputPlayer); }
            if (input == 9) { grid.PlaceMarker(2, 2, inputPlayer); }

        }

    }
}
