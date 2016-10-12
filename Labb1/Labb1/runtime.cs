using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class Runtime
    {
        bool applicationLoop = false;
        List<Dog> allDogs = new List<Dog>();
            // Kommenterat bort de "hårdkodade" hundarna i listan för att få en clean lista varje gång.
            // nu försvinner alla hundar då vi inte sparat ner lista till disk. 
            // jag har även tagit bort steg 1 då dessa låg i loopen här under. 
            //{
            //    new Dog { Name = "Little Helper", Age = 3, Breed = "Golden Retreiver" },
            //    new Dog { Name = "Rudolf", Age = 4, Breed = "Bulldog" },
            //};

    public void Start()
        {
            do
            {
                MainMenu();

            } while (applicationLoop == false);
        }

    public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("A. Display Dog list");
            Console.WriteLine("B. Add new dog to list");
            Console.WriteLine("C. Remove dog from list");
            Console.WriteLine("D. Exit");
            Console.WriteLine("Press the Key of which alternative you would like to choose");

            bool loop = false;
            do
            {
                loop = false;
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.A:
                        DisplayDogList();
                        break;
                    case ConsoleKey.B:
                        AddingDog();
                        break;
                    case ConsoleKey.C:
                        RemoveDogFromList();
                        break;
                    case ConsoleKey.D:
                        applicationLoop = true;
                        break;
                    default:
                        loop = true;
                        break;
                }
            } while (loop);
        }

        public void DisplayDogList()
        {
            Console.Clear();
            int i = 0;
            foreach (var dog in allDogs)
            {
                Console.WriteLine(i + dog.Introduction());
                i++;
            }
            Console.ReadLine();
        }

        public void AddingDog()
        {
            Console.Clear();
            Console.WriteLine("Add new dog below");

            Console.WriteLine("Name ");
            string newDogName = Console.ReadLine();

            Console.WriteLine("Age: ");
            int newDogAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Breed: ");
            string newDogBreed = Console.ReadLine();

            allDogs.Add(new Dog { Name = newDogName, Age = newDogAge, Breed = newDogBreed });
        }

        public void RemoveDogFromList()
        {
            DisplayDogList();
            Console.WriteLine("Enter the number of the row you want to remove");
            int input = int.Parse(Console.ReadLine());
            allDogs.RemoveAt(input);
            Console.Clear();
        }





    }
}
