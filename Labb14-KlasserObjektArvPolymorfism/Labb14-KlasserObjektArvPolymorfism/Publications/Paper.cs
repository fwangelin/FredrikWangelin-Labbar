using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14_KlasserObjektArvPolymorfism
{
    class Paper : Publication
    {
        public override string ToString()
        {
            return string.Format("{0}, Author: {1}, Will be released: {2}", Title, author.Name, ReleaseDate);
        }
    }
}
