using Labb16_InterfaceRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb16_InterfaceRepository.Models;
using Labb16_InterfaceRepository.Manager;

namespace Labb16_InterfaceRepository.Repositories
{
    class ListProductRepository : IProductRepository
    {
        ProductManager manager = new ProductManager();
        public List<Product> ProductList { get; set; }

        public ListProductRepository()
        {
            ProductList = new List<Product>
            {
                new Product {ID = 1, CategoryProp = Product.Category.GameConsole,     Name = "PS4",               Price = 4995 },
                new Product {ID = 2, CategoryProp = Product.Category.KitchenSupply,   Name = "Vattenkokare",      Price = 295 },
                new Product {ID = 3, CategoryProp = Product.Category.TV,              Name = "Bildrörs-TV",       Price = 150 },
                new Product {ID = 4, CategoryProp = Product.Category.Cellphone,       Name = "Mobiltelefon",      Price = 2995 },
                new Product {ID = 5, CategoryProp = Product.Category.Computer,        Name = "Billigaste MAC",    Price = 915987},
                new Product {ID = 6, CategoryProp = Product.Category.MiscElectronics, Name = "Kablar till dator", Price = 99 },

            };
        }

        public void Add(Product newProduct)
        {
            ProductList.Add(newProduct);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return ProductList;
        }

        public void Update(Product updatedProduct)
        {
            throw new NotImplementedException();
        }


    }
}
