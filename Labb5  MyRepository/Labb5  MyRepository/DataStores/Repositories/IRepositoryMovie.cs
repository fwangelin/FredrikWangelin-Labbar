using Labb5__MyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5__MyRepository.DataStores.Repositories
{
    interface IRepositoryMovie
    {
        Movie[] GetMovies();

        void AddMovie(Movie newMovie);
        void RemoveMovie(Movie removeMovie);
    }
}
