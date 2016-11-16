using Labb_12___LINQ.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_12___LINQ
{
    class Runtime
    {
        public void Start()
        {
            var manager = new MovieManager();
            bool menuLoop = true;

            while (menuLoop)
            {
                Console.WriteLine("1. Search movie");
                Console.WriteLine("2. See movies in Genres");
                Console.WriteLine("3. Movies under 120 minutes");
                Console.WriteLine("4. Movie names in Array");
                Console.WriteLine("5. One movie as String");
                Console.WriteLine("6. Movie start with A +120 min and in Sci-Fi");
                var inputLoop = Console.ReadKey(true).Key;

                switch(inputLoop)
                {
                    case ConsoleKey.D1:
                        manager.SearchForMovieName();
                        break;
                    case ConsoleKey.D2:
                        manager.MoviesInGenre();
                        break;
                    case ConsoleKey.D3:
                        manager.MoviesUnder120Minutes();
                        break;
                    case ConsoleKey.D4:
                        manager.NamesInArray();
                        break;
                    case ConsoleKey.D5:
                        manager.FilmToString();
                        break;
                    case ConsoleKey.D6:
                        manager.ChainingSpecifics();
                        break;
                    case ConsoleKey.D7:
                        menuLoop = false;
                        break;
                }
            }
        }
    }
}
