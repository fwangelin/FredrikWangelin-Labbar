using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14_KlasserObjektArvPolymorfism
{
    class Magazine : Publication
    {
        public string HeadLine { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, Headline: {1}, Author: {2}, Will be released: {3}", Title, HeadLine, author.Name, ReleaseDate);
        }
    }
}
