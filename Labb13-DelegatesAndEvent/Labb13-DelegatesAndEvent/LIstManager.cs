using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb13_DelegatesAndEvent.Delegate;

namespace Labb13_DelegatesAndEvent
{
    class ListManager
    {

        public List<TheList> RandomList { get; set; }
        private event IsInvalidname AnalyzeInput;
        TheList newObject = new TheList();
        public string inputName;

        public ListManager()
        {
            AnalyzeInput += new IsInvalidname(() =>
            {
                Console.WriteLine("invalid input");
                Console.ReadKey();
            });

            RandomList = new List<TheList>
            {
                new TheList {TypeProp = TheList.Type.Animal, Name = "Iris" },
                new TheList {TypeProp = TheList.Type.Book,   Name = "the Game" },
                new TheList {TypeProp = TheList.Type.Game,   Name = "WD2" },
                new TheList {TypeProp = TheList.Type.Person, Name = "Elin" },
                new TheList {TypeProp = TheList.Type.Animal, Name = "Ruth" },
                new TheList {TypeProp = TheList.Type.Book,   Name = "Hannibal" },
                new TheList {TypeProp = TheList.Type.Game,   Name = "GTA 5" },
                new TheList {TypeProp = TheList.Type.Person, Name = "Fredrik" },
                new TheList {TypeProp = TheList.Type.Animal, Name = "Agda" },
                new TheList {TypeProp = TheList.Type.Book,   Name = "A Book" },
                new TheList {TypeProp = TheList.Type.Game,   Name = "A Sweet game" },
                new TheList {TypeProp = TheList.Type.Person, Name = "Aniston" },
            };
        }

        public void PrintWhere(TypeFilter filter)
        {
            foreach (var item in RandomList)
            {
                if (filter(item))
                    Console.WriteLine(item.Name);
            }
        }

        public bool IsNameOK(string name)
        {
            char A = 'A';
            char a = 'a';

            //foreach (var input in inputName)
            //{
            if (name.Contains(A))
            {
                Console.WriteLine("You can not use A in your Objects");
                return false;
            }
            else if (name.Contains(a))
            {
                Console.WriteLine("You can not use a in your Objects");
                return false;
            }
            else
            {
                return true;       
            }

        }

        public void FilterMethod()
        {
            var loop = true;

            Runtime runtime = new Runtime();

            TypeFilter animalFilter = Delegate.AllAnimals;
            TypeFilter isYoungFilter = Delegate.AllGames;
            TypeFilter nameStartsWithAFilter = Delegate.AllObjectNameStartWithA;

            Console.Clear();
            Console.WriteLine("Choose Filter:");
            Console.WriteLine();
            Console.WriteLine("1. Show all Animals");
            Console.WriteLine("2. Show all Games");
            Console.WriteLine("3. Show all objects that starts with an A");
            Console.WriteLine("4. Main menu");

            while (loop)
            {
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.WriteLine("All Animals: ");
                        PrintWhere(AllAnimals);
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        Console.WriteLine("All Games: ");
                        PrintWhere(AllGames);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        Console.WriteLine("All Objects that starts with an A");
                        PrintWhere(AllObjectNameStartWithA);
                        break;
                    case ConsoleKey.D4:
                        loop = false;
                        break;
                }
            }
        }

        public TheList CreateObject()
        {
            var isIvalid = true;

            while (isIvalid)
            {
                Console.Clear();
                Console.WriteLine("Object Name:");
                inputName = Console.ReadLine();

                if (IsNameOK(inputName) == true)
                {
                    isIvalid = false;
                }
                else
                {
                    AnalyzeInput.Invoke();
                }
            }

            newObject.Name = inputName;

            Console.WriteLine("What type is it: ");
            PrintObjectCategories();
            Console.Write("Choice: ");
            int choice = int.Parse(Console.ReadLine());
            newObject.TypeProp = (TheList.Type)choice;

            RandomList.Add(newObject);
            return newObject;

        }

        private static void PrintObjectCategories()
        {
            foreach (var objectType in Enum.GetValues(typeof(TheList.Type)))
            {
                Console.WriteLine("{0}, {1}", (int)objectType, objectType);
            }
        }

        public void PrintToConsole()
        {
            foreach (var objects in RandomList)
            {
                Console.WriteLine("Name: {0}, Type: {1}", objects.Name, objects.TypeProp);
            }
            Console.Read();
        }
    }
}
