using Labb16_InterfaceRepository.Interface;
using Labb16_InterfaceRepository.Models;
using Labb16_InterfaceRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb16_InterfaceRepository.Manager
{
    class ProductManager
    {
        private IProductRepository productRepository = new ListProductRepository();

        public void CreateProduct()
        {
            var newProduct = UI.CreateProduct();
            productRepository.Add(newProduct);
        }

        //public void RemoveProduct()
        //{
        //    var product = productRepository.GetPets();
        //    var index = UI.GetID(productRepository.GetPets()) - 1;
        //    petRepository.RemovePets(pet[index]);
        //}


    }
}
