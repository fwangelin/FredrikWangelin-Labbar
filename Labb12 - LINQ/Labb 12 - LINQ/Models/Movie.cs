using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_12___LINQ.Models
{
    class Movie
    {
        public enum Genres { Action = 1, Comedy, Docs, SciFi }
        public string MovieName { get; set; }
        public Genres MovieGenre { get; set; }
        public int MovieLength { get; set; }

    }
}
