using Labb5__MyRepository.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5__MyRepository
{
    class Client
    {
        internal void Start()
        {
            var loop = true;

            while (loop)
            {
                UI.PrintMainMeny();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        PetMenu();
                        break;
                    case ConsoleKey.D2:
                        MovieMenu();
                        break;
                    case ConsoleKey.D3:
                        loop = false;
                        break;

                }
            }
        }

        internal void PetMenu()
        {
            var pets = new PetController();
            var loop = true;

            while (loop)
            {
                UI.PrintPetMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        pets.CreatePet();
                        break;
                    case ConsoleKey.D2:
                        pets.RemovePet();
                        break;
                    case ConsoleKey.D3:
                        pets.EditPet();
                        break;
                    case ConsoleKey.D4:
                        pets.PrintPetList();
                        break;
                    case ConsoleKey.D5:
                        loop = false;
                        break;

                }
            }
        }

        internal void MovieMenu()
        { 
            var movies = new MovieController();
            var loop = true; 

            while (loop)
            {
                UI.PrintMovieMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        movies.CreateMovie();
                        break;
                    case ConsoleKey.D2:
                        movies.RemoveMovie();
                        break;
                    case ConsoleKey.D3:
                        movies.EditMovie();
                        break;
                    case ConsoleKey.D4:
                        movies.PrintMovieList();
                        break;
                    case ConsoleKey.D5:
                        loop = false;
                        break;

                }
            }
        }
    }
}
