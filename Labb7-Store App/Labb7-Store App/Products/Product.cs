using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_Store_App.Products
{
    class Product : ISellable
    {
        public string Brand { get; set; }

        public int PriceForItem { get; set; }

        public string ProductInformation { get; set; }
    }
}
