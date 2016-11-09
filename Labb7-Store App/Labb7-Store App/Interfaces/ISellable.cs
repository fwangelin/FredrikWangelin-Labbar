using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_Store_App
{
    interface ISellable
    {
        int PriceForItem { get; set; }
        string ProductInformation { get; set; }
        string Brand { get; set; }

    }
}
