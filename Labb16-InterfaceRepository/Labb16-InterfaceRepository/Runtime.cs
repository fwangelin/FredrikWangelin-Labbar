using Labb16_InterfaceRepository.Interface;
using Labb16_InterfaceRepository.Manager;
using Labb16_InterfaceRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb16_InterfaceRepository
{
   public class Runtime
    {
        public void Start()
        {
            var manager = new ProductManager();
            var loop = true;

            while (loop)
            {
                UI.PrintMainMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        manager.CreateProduct();
                        break;
                    case ConsoleKey.D2:
                        // Removig products
                        break;
                    case ConsoleKey.D3:
                        // view list
                        break;
                    case ConsoleKey.D4:
                        loop = false;
                        break;

                }
            }



        }
    }
}
