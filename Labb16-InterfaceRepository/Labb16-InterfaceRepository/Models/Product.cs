using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb16_InterfaceRepository.Models
{
    class Product
    {
        public enum Category { Cellphone = 1, Computer, TV, KitchenSupply, GameConsole, MiscElectronics }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category CategoryProp { get; set; }
    }
}
