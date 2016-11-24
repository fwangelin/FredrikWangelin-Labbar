using Labb16_InterfaceRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb16_InterfaceRepository
{
    class UI
    {
        #region Graphics
        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. View products");
            Console.WriteLine("4. Exit");
        }

        #endregion
        public static void PrintProductCategories()
        {
            foreach (var product in Enum.GetValues(typeof(Product.Category)))
            {
                Console.WriteLine("{0}, {1}", (int)product, product);
            }
        }

        public static Product CreateProduct()
        {
            Product newProduct = new Product();

            Console.WriteLine("Set Category: ");
            PrintProductCategories();
            Console.Write("Choice: ");
            int choice = int.Parse(Console.ReadLine());
            newProduct.CategoryProp = (Product.Category)choice;

            Console.Clear();
            Console.WriteLine("Set Product ID:");
            newProduct.ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Set Product Name");
            newProduct.Name = Console.ReadLine();

            Console.WriteLine("Set Price:");
            newProduct.Price = int.Parse(Console.ReadLine());

            return newProduct;

        }

        public static void EditProduct(Product product)
        {
            Console.Clear();
            Console.WriteLine("1. Change Category");
            Console.WriteLine("2. Change ID");
            Console.WriteLine("3. Change Name");
            Console.WriteLine("4. Change Price");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Category: {0}, ID: {1}, Name: {2}, Price: {3}",
                                product.CategoryProp,
                                product.ID,
                                product.Name,
                                product.Price);

            switch (choice)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Categories:");
                    PrintProductCategories();
                    Console.Write("Set new Category: ");
                    product.CategoryProp = (Product.Category)int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D2:
                    Console.Write("Set new ID: ");
                    product.ID = int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D3:
                    Console.Write("Set new Name: ");
                    product.Name = Console.ReadLine();
                    break;

                case ConsoleKey.D4:
                    Console.Write("Set new Price: ");
                    product.Price = int.Parse(Console.ReadLine());
                    break;
            }
        }

        public static int GetID(List<Product> allProducts)
        {
            PrintProducts(allProducts);
            Console.Write("Select ID: ");
            return int.Parse(Console.ReadLine());
        }

        public static void PrintProducts(List<Product> allProducts)
        {
            Console.Clear();
            foreach (var product in allProducts)
            {
                Console.WriteLine("Category: {0}. ID: {1}, Name: {2}, Name: {3}, Price: {4}",
                                product.CategoryProp.ToString(),
                                product.ID,
                                product.Name,
                                product.Price);
            }
        }
    }
}
