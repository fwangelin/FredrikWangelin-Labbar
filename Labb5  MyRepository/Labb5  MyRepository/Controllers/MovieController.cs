using Labb5__MyRepository.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5__MyRepository.Controllers
{
    class MovieController
    {
        private IRepositoryMovie movieRepository = new ListRepositoryForMovie();

        public void CreateMovie()
        {
            var newMovie = UI.CreateMovie();
            movieRepository.AddMovie(newMovie);
        }

        public void RemoveMovie()
        {
            var movie = movieRepository.GetMovies();
            var index = UI.SelectMovie(movieRepository.GetMovies()) - 1;
            movieRepository.RemoveMovie(movie[index]);
        }

        public void PrintMovieList()
        {

            Console.Clear();
            UI.PrintMovies(movieRepository.GetMovies());
            Console.ReadKey(true);

        }

        public void EditMovie()
        {
            var movies = movieRepository.GetMovies();
            UI.PrintMovies(movies);
            int index = UI.SelectMovie(movies) - 1;

            UI.EditMovie(movies[index]);
        }
    }
}
