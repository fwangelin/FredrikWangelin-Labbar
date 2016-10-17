using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2InherencePolymorphism
{
    class Menues
    {
        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine();
            Console.WriteLine("1. Add an animal");
            Console.WriteLine("2. Remove an animal");
            Console.WriteLine("3. Show lists of animals");
            Console.WriteLine("4. Exit");
        }

        public static void PrintAddAnimalMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose what type of animal you want to add");
            Console.WriteLine();
            Console.WriteLine("1. Fish");
            Console.WriteLine("2. Birds");
            Console.WriteLine("3. Reptiles");
            Console.WriteLine("4. Mammals");
            Console.WriteLine("5. Exit");
        }
        public static void PrintRemoveAnimalMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose what type of animal you want to remove");
            Console.WriteLine();
            Console.WriteLine("1. Fish");
            Console.WriteLine("2. Birds");
            Console.WriteLine("3. Reptiles");
            Console.WriteLine("4. Mammals");
            Console.WriteLine("5. Exit");
        }
        public static void PrintDisplayAnimalMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose what type of animal you want to display");
            Console.WriteLine();
            Console.WriteLine("1. Fish");
            Console.WriteLine("2. Birds");
            Console.WriteLine("3. Reptiles");
            Console.WriteLine("4. Mammals");
            Console.WriteLine("5. Exit");
        }
        public static void PrintFishMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("1. Shark");
            Console.WriteLine("2. Reef-fish");
            Console.WriteLine("3. Show all fish");
            Console.WriteLine("4. Exit");
        }
        public static void PrintBirdMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("1. Eagle");
            Console.WriteLine("2. Penguins");
            Console.WriteLine("3. Show all Birds");
            Console.WriteLine("4. Exit");
        }
        public static void PrintReptileMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("1. Snakes");
            Console.WriteLine("2. Lizards");
            Console.WriteLine("3. Show all Reptiles");
            Console.WriteLine("4. Exit");
        }
        public static void PrintMammalMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("1. Whales");
            Console.WriteLine("2. Cats");
            Console.WriteLine("3. Show all Mammals");
            Console.WriteLine("4. Exit");
        }
    }
}
