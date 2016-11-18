using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13_DelegatesAndEvent
{
    class Delegate
    {
        public delegate bool TypeFilter(TheList filterList);
        public delegate void IsInvalidname(); 

        public static bool AllAnimals(TheList filterList)
        {
            return filterList.TypeProp == TheList.Type.Animal;
        }

        public static bool AllGames(TheList filterList)
        {
            return filterList.TypeProp == TheList.Type.Game;
        }

        public static bool AllObjectNameStartWithA(TheList filterList)
        {
            return filterList.Name[0]== 'A';
        }


    }
}
