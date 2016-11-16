using Labb_12___LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_12___LINQ.Managers
{
    class MovieManager
    {
        public List<Movie> MovieList { get; set; }

        public MovieManager()
        {
            MovieList = new List<Movie>
            {
                new Movie {MovieName = "Awsome shooting",        MovieGenre = Movie.Genres.Action, MovieLength = 110 },
                new Movie {MovieName = "Fuck yeah bro!",         MovieGenre = Movie.Genres.Action, MovieLength = 121 },
                new Movie {MovieName = "Holy Shit",              MovieGenre = Movie.Genres.Action, MovieLength = 102 },
                new Movie {MovieName = "A. Sandler is not funny",MovieGenre = Movie.Genres.Comedy, MovieLength = 131 },
                new Movie {MovieName = "Dying at work",          MovieGenre = Movie.Genres.Comedy, MovieLength = 130 },
                new Movie {MovieName = "Talladega nights",       MovieGenre = Movie.Genres.Comedy, MovieLength = 85  },
                new Movie {MovieName = "Funny stuff",            MovieGenre = Movie.Genres.Comedy, MovieLength = 130 },
                new Movie {MovieName = "A documentary",          MovieGenre = Movie.Genres.Docs,   MovieLength = 136 },
                new Movie {MovieName = "Importance",             MovieGenre = Movie.Genres.Docs,   MovieLength = 90  },
                new Movie {MovieName = "As a nice doc",          MovieGenre = Movie.Genres.Docs,   MovieLength = 126 },
                new Movie {MovieName = "Why are you here?",      MovieGenre = Movie.Genres.Docs,   MovieLength = 116 },
                new Movie {MovieName = "Space stuff",            MovieGenre = Movie.Genres.SciFi,  MovieLength = 100 },
                new Movie {MovieName = "Wormholes and lazers",   MovieGenre = Movie.Genres.SciFi,  MovieLength = 97  },
                new Movie {MovieName = "Ass Lazer sword",        MovieGenre = Movie.Genres.SciFi,  MovieLength = 181 },
                new Movie {MovieName = "Trek that shit",         MovieGenre = Movie.Genres.SciFi,  MovieLength = 116 }

            };
        }

        public void SearchForMovieName()
        {
            var loop = true;

            while (loop)
            {
                Console.Write("Input search word: ");
                string input = Console.ReadLine();

                Movie[] movies = MovieList.Where(name => name.MovieName.ToUpper().Contains(input.ToUpper())).ToArray();
                if (movies.Length > 0)
                {

                    foreach (var movie in movies)
                    {
                        Console.WriteLine("Search Result: {0}, Genre: {1}, Length: {2} minutes", movie.MovieName.ToString(),
                                          movie.MovieGenre, movie.MovieLength);
                    }
                }
                else { Console.WriteLine("No match"); }
            }
        }

        public void MoviesInGenre()
        {
            var loop = true;

            while (loop)
            {
                
                Console.WriteLine("1. Action");
                Console.WriteLine("2. Comedy");
                Console.WriteLine("3. Documentary");
                Console.WriteLine("4. Sci-Fi");
                Console.WriteLine("5. quit");

                int input = int.Parse(Console.ReadLine());

                Movie[] genres = MovieList.Where(genre => genre.MovieGenre == (Movie.Genres)input).ToArray();
                foreach (var movies in genres)
                {
                    
                    Console.WriteLine("{0}: {1}", movies.MovieGenre.ToString(), movies.MovieName);
                    
                }
             }
         }

        public void MoviesUnder120Minutes()
        {
            var loop = true;

            while (loop)
            {

                Console.WriteLine("Movies under 120 minutes:");

                Movie[] movies = MovieList.Where(length => length.MovieLength < 120).ToArray();
                foreach (var movie in movies)
                 {
                     Console.WriteLine("{0}, Genre: {1}, Length: {2} minutes", movie.MovieName.ToString(),
                                       movie.MovieGenre, movie.MovieLength);
                    
                 }
                Console.Read();

            }
        }

        public void NamesInArray()
        {
            string[] movieNames = MovieList.Select(movie => movie.MovieName).ToArray();

            foreach (var names in movieNames)
            {
                Console.WriteLine("Name: {0}", names);
            }
        }

        public void FilmToString()
        {
            string filmToString = MovieList.SingleOrDefault(movie => String.Equals(movie.MovieName, "A. Sandler is not funny")).MovieName;

                Console.WriteLine("The movie in String is: {0}", filmToString);
        }

        public void ChainingSpecifics()
        {
            Movie[] movies = MovieList.Where(movie => movie.MovieName[0] == 'A' &&
                                             movie.MovieLength > 120 &&
                                             movie.MovieGenre == Movie.Genres.SciFi)
                                             .ToArray();

            foreach (var chainedMovie in movies)
            {
                Console.WriteLine("Random specific: {0}, Length: {1}, Genre: {2}", 
                    chainedMovie.MovieName, chainedMovie.MovieLength, chainedMovie.MovieGenre);
            }
        }





    }
}

