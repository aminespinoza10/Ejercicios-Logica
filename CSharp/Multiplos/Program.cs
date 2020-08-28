using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiplos
{
    class Program
    {
        static List<int> multiples = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecución de aplicación");
            IsNumberDivisible();
            string finalResult = GetFinalSum();
            Console.Write("Tu resultado es: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(finalResult);
        }

        static void IsNumberDivisible()
        {
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    multiples.Add(i);
                }
                if (i % 5 == 0)
                {
                    multiples.Add(i);
                }
            }
        }

        static string GetFinalSum()
        {
            List<int> finalCleanList = multiples.Distinct().ToList();
            int finalNumber = 0;

            foreach (int item in finalCleanList)
            {
                finalNumber += item;
            }

            return finalNumber.ToString();
        }
    }
    
}
