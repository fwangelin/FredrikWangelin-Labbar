using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class Runtime
    {
        public void Start()
        {
            #region Step One
            //  This was step 1, but I put them directly in "List" for step 2...
            //Dog dog1 = new Dog
            //{
            //    Name = "Little Helper",
            //    Age = 3,
            //    Breed = "Golden Retreiver"
            //};
            //Dog dog2 = new Dog("Rudolf", 4, "Bulldog");
            #endregion Step One

            #region Step Two
            List<Dog> allDogs = new List<Dog>()
            {
                new Dog { Name = "Little Helpe", Age = 3, Breed = "Golden Retreiver" },
                new Dog { Name = "Rudolf", Age = 4, Breed = "Bulldog" },
            };
            foreach (var dog in allDogs)
            {
                Console.WriteLine(dog.Introduction());
            }
            #endregion Step Two
        }


    }
}
