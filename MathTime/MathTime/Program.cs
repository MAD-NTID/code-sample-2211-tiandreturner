using System;

namespace MathTime
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"PI: {Math.PI}");

            double currentNumber = Math.Ceiling(3.14);
            Console.WriteLine($"Ceiling value: {currentNumber}");

            currentNumber = Math.Floor(3.14);
            Console.WriteLine($"Floor value: {currentNumber}");

            currentNumber = Math.Round(3.14);
            Console.WriteLine($"Rounding value: {currentNumber}");

            currentNumber = Math.Round(3.145674,2);
            Console.WriteLine($"Rounding value: {currentNumber}");

            currentNumber = Math.Pow(2, 3);
            Console.WriteLine($"Pow Value: {currentNumber}");

            currentNumber = Math.Sqrt(Math.Pow(3, 2));
            Console.WriteLine($"Square root Value: {currentNumber}");
        }
    }
}
