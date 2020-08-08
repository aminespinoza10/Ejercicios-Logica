using System;
using System.Collections.Generic;

namespace Primos
{
    class Program
    {
        static List<int> primesList = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecución de aplicación");
            
            Console.Write("Tu resultado es: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            GetPrimes();
            //Console.WriteLine(finalResult);
        }

        static void GetPrimes()
        {
            for (int i = 1; i < 2000000; i++)
            {
                if (isPrime(i))
                {
                    primesList.Add(i);
                }
            }
            GetSumOfPrimes();
        }

        static bool isPrime(int number)
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

        static void GetSumOfPrimes()
        {
            int finalSum = 0;

            foreach (int item in primesList)
            {
                finalSum += item;
            }

            Console.WriteLine(finalSum);
        }
    }
}
