using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_Store_App
{
    class UI
    {
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("   Welcome to The Store (tm)");
            Console.WriteLine();
            Console.WriteLine("   Please choose one of the following options");
            Console.WriteLine();
            Console.WriteLine("1. Display products in stock");
            Console.WriteLine("2. Add Items to the shop");
            Console.WriteLine("3. Customer basket");
            Console.WriteLine("4. Exit");
        }
    }
}
