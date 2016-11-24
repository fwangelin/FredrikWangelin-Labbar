using Labb16_InterfaceRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb16_InterfaceRepository.Interface
{
    interface IProductRepository
    {
        void Add(Product newProduct);
        Product Get(int id);
        List<Product> GetAll();
        void Update(Product updatedProduct);
        void Delete(int id);
    

    }
}
