using Labb5__MyRepository.DataStores.Repositories;
using Labb5__MyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5__MyRepository.Controllers
{
    class PetController
    {
        private IRepositoryPet petRepository = new ListRepositoryForPet();

        public void CreatePet()
        {
            var newPet = UI.CreatePet();
            petRepository.AddPet(newPet);
        }

        public void RemovePet()
        {
            var pet = petRepository.GetPets();
            var index = UI.SelectPet(petRepository.GetPets()) - 1;
            petRepository.RemovePets(pet[index]);
        }

        public void PrintPetList()
        {

            Console.Clear();
            UI.PrintPets(petRepository.GetPets());
            Console.ReadKey(true);

        }

        public void EditPet()
        {
            var pets = petRepository.GetPets();
            UI.PrintPets(pets);
            int index = UI.SelectPet(pets) - 1;

            UI.EditPet(pets[index]);
        }
    }
}
