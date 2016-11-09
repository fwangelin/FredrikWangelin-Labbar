using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8_Delegater
{
    class DelegateClass
    {
        public delegate string StringConcatinator(List<string> messageFromConcatinator);
        public delegate float NumberOperator(List<float> collectionOfFloatNumber);

    }
}
