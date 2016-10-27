using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb5__MyRepository.Models;

namespace Labb5__MyRepository.DataStores.Repositories
{
    class ListRepositoryForMovie : IRepositoryMovie
    {
        public Movie[] GetMovies()
        {
            return MyLists.Movie.ToArray();
        }

        public void AddMovie(Movie newMovie)
        {
            MyLists.Movie.Add(newMovie);
        }

        public void RemoveMovie(Movie removeMovie)
        {
            MyLists.Movie.Remove(removeMovie);
        }
    }
}
