using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public Dog()
        {
        }

        public Dog(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }
        public string Introduction()
        {
            return String.Format(": Dogs name is {0}, it's age is {1} and the breed is {2}",
                                 Name, Age, Breed);

        }

    }
}
