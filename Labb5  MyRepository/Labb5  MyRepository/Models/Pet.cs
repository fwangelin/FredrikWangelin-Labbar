using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5__MyRepository.Models
{
    class Pet
    {
        public enum PetCategories
        {
            Antiloop = 1,
            Bee,
            Bird,
            Cat,
            Cattle,
            Chicken,
            Dog,
            Pig,
            WaterBuffalo,
            
        }
        public string PetName { get; set; }
        public int PetAge { get; set; }
        public int LifeSpan { get; set; }
        public PetCategories PetGenres { get; set; }
    }
}
