using Labb5__MyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5__MyRepository.DataStores.Repositories
{
    class ListRepositoryForPet : IRepositoryPet
    {
        public Pet[] GetPets()
        {
            return MyLists.Pet.ToArray();
        }

        public void AddPet(Pet newPet)
        {
            MyLists.Pet.Add(newPet);
        }

        public void RemovePets(Pet removePets)
        {
            MyLists.Pet.Remove(removePets);
        }
    }
}
