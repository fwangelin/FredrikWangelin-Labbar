using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb11_Events
{
    public delegate void AnalyzeNumber();

    public class Runtime
    {
        private event AnalyzeNumber NumberInput;
        public static int userInput;

        public void Start()
        {
                Console.Write("Enter a number: ");
                userInput = int.Parse(Console.ReadLine());

                NumberInput += new AnalyzeNumber(IsEven);
                NumberInput += new AnalyzeNumber(IsDivisableByThree);
                NumberInput += new AnalyzeNumber(IsPrimeNumber);
                

                OnApplicationStarted();
            
        }

        private void OnApplicationStarted()
        {
            NumberInput.Invoke();
        }

        public void IsEven()
        {
            if (userInput % 2 == 0)
            {
                Console.WriteLine("This is an even number");
            }
            else
            {
                Console.WriteLine("This is an odd number...");
            }
        }

        public void IsDivisableByThree()
        {
            if ((userInput % 3) == 0)
            {
                Console.WriteLine("This is divisable with 3");
            }
            else
            {
                Console.WriteLine("This is not divisable with 3");
            }
        }

        public void IsPrimeNumber()
        {
            if (isPrime(userInput))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
        }
        public static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
