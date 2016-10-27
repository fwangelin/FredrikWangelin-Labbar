using Labb5__MyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5__MyRepository.DataStores.Repositories
{
    interface IRepositoryPet
    {
        Pet[] GetPets();

        void AddPet(Pet newPet);
        void RemovePets(Pet removePets);
    }
}
