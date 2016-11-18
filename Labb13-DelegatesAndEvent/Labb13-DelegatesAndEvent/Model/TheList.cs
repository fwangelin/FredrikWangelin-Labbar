using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13_DelegatesAndEvent
{
    class TheList
    {
        public enum Type { Animal=1, Game, Book, Person }

        public Type TypeProp { get; set; }
        public string Name { get; set; }


    }
}
