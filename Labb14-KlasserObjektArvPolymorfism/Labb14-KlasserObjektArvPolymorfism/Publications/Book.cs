using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14_KlasserObjektArvPolymorfism
{
    class Book : Publication
    {
        public enum Genre { Action=1, Biography, Comedy, History, Horror, SciFi,  }

        public int Pages { get; set; }
        public Genre Genres { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, Författare: {1}, Genre: {2}, Antal sidor: {3}, Släpps: {4}",
                                Title, author.Name, Genres.ToString(), Pages, ReleaseDate);
        }
        

    }
}
