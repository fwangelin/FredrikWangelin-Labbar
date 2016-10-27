using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5__MyRepository.Models
{
    class Movie
    {
        public enum GenreCategories
        {
            Action = 1,
            Comedy,
            Documentary,
            Horror,
            SciFi,
            Thriller
        }
        public string MovieName { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public float Length { get; set; }
        public GenreCategories Genre { get; set; }
    }
}
