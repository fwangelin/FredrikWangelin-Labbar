using Labb5__MyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5__MyRepository.DataStores
{
    class MyLists
    {
        private static List<Movie> movie;
        private static List<Pet> pet;

        public static List<Movie> Movie
        {
            get
            {
                if (movie == null)
                    movie = new List<Movie>();
                return movie;
            }
        }

        public static List<Pet> Pet
        {
            get
            {
                if (pet == null)
                    pet = new List<Pet>();
                return pet;
            }
        }
    }
}
