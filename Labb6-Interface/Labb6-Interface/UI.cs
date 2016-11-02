using Labb6_Interface.Classes;
using Labb6_Interface.EnviromentModels;
using Labb6_Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Interface
{
    class UI
    { 

        public void Humans()
        {
            var humanLoop = true;
            var human = new Human();

            Console.Clear();
            Console.WriteLine("the Person is:");
            Console.WriteLine(human.Appearence);
            Console.WriteLine(human.Movement);
            Console.WriteLine();
            Console.WriteLine("Saying:");
            Console.WriteLine(human.Speak());
            Console.WriteLine();
            Console.WriteLine("Would you like to help? Y/N or A to give the answer to his wish");
            var input = Console.ReadKey(true).Key;

            if (humanLoop)
            {
                switch (input)
                {
                    case ConsoleKey.Y:
                        HelpHumanQuestion();
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine("Ok.. (looking even sadder)");
                        humanLoop = false;
                        break;
                    case ConsoleKey.A:
                        HelpHumanAnswer();
                        break;
                }
            }
            else { humanLoop = false; }

        }

        public void Ghosts()
        {
            var ghost = new Ghost();
            var ghostLoop = true;

            Console.Clear();
            Console.WriteLine("the Ghost is:");
            Console.WriteLine(ghost.Appearence);
            Console.WriteLine(ghost.Movement);
            Console.WriteLine("Saying:");
            Console.WriteLine(ghost.Speak());
            Console.WriteLine("\nHave you seen him? Y/N\n");

            var input = Console.ReadKey(true).Key;

            if (ghostLoop)
            {
                switch (input)
                {
                    case ConsoleKey.Y:
                        AnswersFromGhost();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine("Ok, let me know if you do!");
                        Console.ReadKey(true);
                        ghostLoop = false;
                        break;
                }
            }
            else { ghostLoop = false; }

        }

        public void Animals()
        {
            var animal = new Animal();

            Console.Clear();
            Console.WriteLine("the Animal is:");
            Console.WriteLine(animal.Appearence);
            Console.WriteLine(animal.Movement);
            Console.WriteLine("Saying:");
            Console.WriteLine(animal.Speak());

        }

        public void Yards()
        {
            var yard = new Yard();

            Console.WriteLine(yard.EnviromentObservation());
        }

        public void Rooms()
        {
            var room = new Room();

            Console.WriteLine(room.EnviromentObservation());
        }

        public void HelpHumanQuestion()
        {
            Console.Clear();
            Console.WriteLine("My mother is haunting the mansion, if you dare to enter the mansion you can ask her a question.\n"+
                "If you ask the right question, she will let you know how I can also pass on.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            
        }

        public void HelpHumanAnswer() // As a penalty for not remembering Answer, you get "pushed" back to yard
        {
            var humanLoop = true;

            while (humanLoop)
            {
                Console.Clear();
                Console.WriteLine("Thank you for returning, do you have the answer I'm looking for?\n\n");
                Console.WriteLine("enter the number of the answer and I will be released from my pains\n" +
                    "Can you remember what it was???\nHint: answers between 1-6");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.D2:
                    case ConsoleKey.D3:
                    case ConsoleKey.D5:
                    case ConsoleKey.D6:
                        Console.WriteLine("No, thats not it, I'm not swirling towards heaven...\n");
                        Console.WriteLine("         *Getting pushed back to yard*");
                        humanLoop = false;
                        break;
  
                    case ConsoleKey.D4:
                        Console.WriteLine("Thats it! Wohoo, thank you! Although I can see the light!");
                        Console.WriteLine("Press any key to continue");
                        WinGame();
                        break;
                }
            }

        }

        public void AnswersFromGhost()
        {
            Console.Clear();
            Console.WriteLine("One of these answers will help my son, please remember them and choose wisely\n");
            Console.WriteLine("%. Find God");
            Console.WriteLine("@. Read the bible at least once");
            Console.WriteLine("!. Hurt animals");
            Console.WriteLine("¤. Have a Arboga 10,2 and drink it at a park bench in Liljeholmen centrum"); // Right answer
            Console.WriteLine("&. Have zero emotions");
            Console.WriteLine("#. Eat the white dog shit");

        }

        public void WinGame()
        {
            Console.Clear();
            Console.WriteLine("You finished the game! Congratulations, you are awsome!");
            Console.ReadKey(true);
            Environment.Exit(0);
        }

        public void LoseGame()
        {
            Console.Clear();
            Console.WriteLine("You are pretty damn dead and you will have to restart");
            Console.ReadKey(true);
            Environment.Exit(0);
        }

    }
}
