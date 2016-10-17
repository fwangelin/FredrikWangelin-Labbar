using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2InherencePolymorphism
{
    class Runtime
    {
        Sharks sharks = new Sharks();
        bool mainMenuLoop = true;

        public void Start()
        {
            #region Print Hardcoded animals to console

            //Sharks greatWhiteShark = new Sharks
            //{
            //    Name = "Great White Shark",
            //    Age = 5,
            //    Weight = 100,
            //    Sound = "Stupid",
            //    Movement = "Flappedi flap",
            //    CanSwim = "YES",
            //    IsPredator = "YES"
            //};
            //ReefFish ClownFish = new ReefFish
            //{
            //    Name = "ClownFish",
            //    Age = 1,
            //    Weight = 0.02,
            //    Sound = "blubb",
            //    Movement = "moonwalk",
            //    CanSwim = "YES",
            //    FavouritePlankton = "Bubblegum Plankton"
            //};
            //Eagles baldEagle = new Eagles
            //{
            //    Name = "American Bald Eagle",
            //    Age = 10,
            //    Weight = 20,
            //    Sound = "Stupid",
            //    Movement = "Flappedi flap",
            //    WingSpan = "2 meter",
            //    CanBeFoundInWhatCountry = "USA"
            //};
            //Penguins gentlemanPenguin = new Penguins
            //{
            //    Name = "Suit wearing Penguin",
            //    Age = 600,
            //    Weight = 7.9,
            //    Sound = "Wisdom words",
            //    Movement = "Whiskey glass towards mouth",
            //    WingSpan = "5 meter",
            //    WtfIsAPenguin = "In this case, a true gentleman"
            //};
            //Snakes rattleSnake = new Snakes
            //{
            //    Name = "Rattlesnake",
            //    Age = 4,
            //    Weight = 1.3,
            //    Sound = "Hissing",
            //    Movement = "Snailing really fast",
            //    ColdBlooded = "YES",
            //    Venomous = "YES"
            //};
            //Lizards gecko = new Lizards
            //{
            //    Name = "Gecko",
            //    Age = 2,
            //    Weight = 0.3,
            //    Sound = "snoring",
            //    Movement = "Crawling",
            //    ColdBlooded = "YES",
            //    LivesOnLandOrBoth = "On Land"
            //};
            //Whales blueWhale = new Whales
            //{
            //    Name = "Blue Whale",
            //    Age = 15,
            //    Weight = 10000,
            //    Sound = "Whale noises",
            //    Movement = "Swimming",
            //    NumberOfLegs = 0,
            //    IsThisFuckingWhaleBig = "YES"
            //};
            //Cats cheetah = new Cats
            //{
            //    Name = "Cheetah",
            //    Age = 9,
            //    Weight = 30.7,
            //    Sound = "Roar",
            //    Movement = "running",
            //    NumberOfLegs = 4,
            //    PetOrWild = "Wild"
            //};

            //Console.WriteLine(greatWhiteShark.IntroductionOfAnimals());
            //Console.WriteLine(ClownFish.IntroductionOfAnimals());
            //Console.WriteLine(baldEagle.IntroductionOfAnimals());
            //Console.WriteLine(gentlemanPenguin.IntroductionOfAnimals());
            //Console.WriteLine(rattleSnake.IntroductionOfAnimals());
            //Console.WriteLine(gecko.IntroductionOfAnimals());
            //Console.WriteLine(blueWhale.IntroductionOfAnimals());
            //Console.WriteLine(cheetah.IntroductionOfAnimals());
            #endregion

            while (mainMenuLoop)
            {
                Menues.PrintMainMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        AddAnimalMenu();
                        break;
                    case 2:
                        RemoveAnimalMenu();
                        break;
                    case 3:
                        DisplayAnimalMenu();
                        break;
                    case 4:
                        mainMenuLoop = false;
                        break;
                }
            }
        }

            public void AddAnimalMenu()
        {
                Menues.PrintAddAnimalMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        AddFishMenu();
                        break;
                    case 2:
                        AddBirdMenu();
                        break;
                    case 3:
                        AddReptileMenu();
                        break;
                    case 4:
                        AddMammalMenu();
                        break;
                    case 5:
                        Start();
                        break;
                default:
                    Console.WriteLine("Please choose a valid menu choice!");
                    break;
                }
        }
            public void RemoveAnimalMenu()
        {
                Menues.PrintRemoveAnimalMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        RemoveFishMenu();
                        break;
                    case 2:
                        RemoveBirdMenu();
                        break;
                    case 3:
                        RemoveReptileMenu();
                        break;
                    case 4:
                        RemoveMammalMenu();
                        break;
                    case 5:
                        Start();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid menu choice!");
                        break;
            }
        }
            public void DisplayAnimalMenu()
        {
                Menues.PrintDisplayAnimalMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        DisplayFishMenu();
                        break;
                    case 2:
                        DisplayBirdMenu();
                        break;
                    case 3:
                        DisplayReptileMenu();
                        break;
                    case 4:
                        DisplayMammalMenu();
                        break;
                    case 5:
                        Start();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid menu choice!");
                        break;
            }
        }

            public void AddFishMenu()
        {
                Menues.PrintFishMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        sharks.AddShark();
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        Start();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid menu choice!");
                        break;
            }
        }
            public void RemoveFishMenu()
        {
                Menues.PrintFishMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        sharks.RemoveShark();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:
                        //restOfMenuLoops = false;
                        Start();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid menu choice!");
                        break;
            }
        }
            public void DisplayFishMenu()
        {
                Menues.PrintFishMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        sharks.ShowSharkList();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:
                        Start();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid menu choice!");
                        break;
            }
            
        }

            public void AddBirdMenu()
        {
                Menues.PrintBirdMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;
                case 4:
                    Start();
                    break;
                default:
                    Console.WriteLine("Please choose a valid menu choice!");
                    break;
            }
        }
            public void RemoveBirdMenu()
        {
                Menues.PrintBirdMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;
                    case 4:
                        Start();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid menu choice!");
                        break;
                }
        }
            public void DisplayBirdMenu()
        {
                Menues.PrintBirdMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;
                    case 4:
                        Start();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid menu choice!");
                        break;
                }
        }

            public void AddReptileMenu()
        {
                Menues.PrintReptileMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;
                    case 4:
                        Start();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid menu choice!");
                        break;
                }
        }
            public void RemoveReptileMenu()
        {
                Menues.PrintReptileMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;
                    case 4:
                        Start();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid menu choice!");
                        break;
                }
        }
            public void DisplayReptileMenu()
        {
                Menues.PrintReptileMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;;
                    case 4:
                        Start();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid menu choice!");
                        break;
                }
        }

            public void AddMammalMenu()
        {
                Menues.PrintMammalMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;
                case 4:
                    Start();
                    break;
                default:
                    Console.WriteLine("Please choose a valid menu choice!");
                    break;
            }
        }
            public void RemoveMammalMenu()
        {
                Menues.PrintMammalMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;
                    case 4:
                        Start();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid menu choice!");
                        break;
                }
        }
            public void DisplayMammalMenu()
        {
                Menues.PrintMammalMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;
                    case 4:
                        Start();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid menu choice!");
                        break;
                }
        }



    }
}
