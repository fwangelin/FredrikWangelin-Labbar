using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2InherencePolymorphism
{
    public class Sharks : Fish
    {
        public string IsPredator { get; set; }
        public static List<Sharks> Shark { get; set; }

        public void SharkManager()
        {
            Shark = new List<Sharks>()
        {
            new Sharks
            {
                Name = "Great White Shark",
                Age = 5,
                Weight = 100,
                Sound = "Stupid",
                Movement = "Flappedi flap",
                CanSwim = "YES",
                IsPredator = "YES"
            }
        };

        }

        public void AddShark()
        {
            Sharks newShark = new Sharks();

            Console.Write("Name: ");
            newShark.Name = Console.ReadLine();

            Console.Write("Age: ");
            newShark.Age = int.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            newShark.Weight = double.Parse(Console.ReadLine());

            Console.Write("Sound: ");
            newShark.Sound = Console.ReadLine();

            Console.Write("Movement: ");
            newShark.Movement = Console.ReadLine();

            Console.Write("Can it swim: ");
            newShark.CanSwim = Console.ReadLine();

            Console.Write("Is it a predator: ");
            newShark.IsPredator = Console.ReadLine();

            Shark.Add(newShark);
        }

        public void RemoveShark()
        {
            for (int i = 1; i <= Shark.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, Shark[i - 1].Name);
            }

            Console.Write("Choice: ");
            int index = int.Parse(Console.ReadLine());

            Shark.RemoveAt(index - 1);
        }

        public void ShowSharkList()
        {
            foreach (var shark in Shark)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Weight: {2}, Sound: {3}, Movement: {4}, Can it Swim: {5}, Is it a predator: {6}",
                                  shark.Name,
                                  shark.Age,
                                  shark.Weight,
                                  shark.Sound,
                                  shark.Movement,
                                  shark.CanSwim,
                                  shark.IsPredator);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }

        //public override string IntroductionOfAnimals()
        //{

        //    return String.Format("{0} Can it swim: {1} Is it a predator: {2}",
        //                        base.IntroductionOfAnimals(),
        //                        CanSwim,
        //                        IsPredator);

        //}
    }
}