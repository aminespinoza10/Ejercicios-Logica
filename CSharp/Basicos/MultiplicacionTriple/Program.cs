using System;

namespace MultiplicacionTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola! Comencemos con recibir el primer número:");
            int numberOne = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ahora dame el segundo número");
            int numberTwo = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Vamos por el el tercer número");
            int numberThree = Convert.ToInt16(Console.ReadLine());
            int operationResult = Multiplicate(numberOne, numberTwo, numberThree);
            Console.WriteLine($"Tu resultado es {operationResult}");
        }

        static int Multiplicate(int firstNumber, int secondNumber, int thirdNumber)
        {
            int result = (firstNumber * secondNumber) * thirdNumber;
            return result;
        }
    }
}
