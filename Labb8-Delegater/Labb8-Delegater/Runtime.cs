using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb8_Delegater.DelegateClass;

namespace Labb8_Delegater
{
    class Runtime
    {
        List<string> stringList = new List<string>()
            {
                "Lussebulle, ",
                "Glögg, ",
                "Julmust, ",
                "Pepparkakor ",
                "är ",
                "riktigt ",
                "gott!"
            };

        List<float> numberList = new List<float>()
            {
                7.3F,
                8.9F,
                9.9F,
                10.4F,
                1.67F,
                2.3F
            };

        public string ConcatinatorMethod(List<string> messageFromConcatinator)
        {
            string stringResult = string.Join(null, messageFromConcatinator);
            return stringResult;
        }

        public float FloatAddition(List<float> collectionOfFloatNumber)
        {
            float addNumbers = 0.0F;

            foreach (var floatNumber in collectionOfFloatNumber)
            {
                addNumbers += floatNumber;
            }
            return addNumbers;
        }

        public float FloatMultiplier(List<float> collectionOfFloatNumber)
        {
            float timesNumbers = 1;

            foreach (var floatNumber in collectionOfFloatNumber)
            {
                timesNumbers *= floatNumber;
            }
            return timesNumbers;
        }

        public void Start()
        {
            NumberOperator NumberFromOperatorAddition = new NumberOperator(FloatAddition);
            NumberOperator NumberFromOperatorMultiply = new NumberOperator(FloatMultiplier);
            StringConcatinator StringFromContatinator = new StringConcatinator(ConcatinatorMethod);

            var menuLoop = true;

            while (menuLoop)
            {
                Console.WriteLine("Tja! Jag gjorde en meny också för att det är typ det jag är bäst på! :D");
                Console.WriteLine("1. String Lista");
                Console.WriteLine("2. Float addering");
                Console.WriteLine("3. Multiplicera Float");
                Console.WriteLine("4. Hem och snusa");

                var input = Console.ReadKey(true).Key;

                switch(input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("String list:");
                        Console.WriteLine(StringFromContatinator(stringList));
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Float Addition:");
                        Console.WriteLine(NumberFromOperatorAddition(numberList));
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Multiplying Floats:");
                        Console.WriteLine(NumberFromOperatorMultiply(numberList));
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Brexiting...");
                        Console.WriteLine();
                        menuLoop = false;
                        break;
                }
            }

        }
         

    }
}
