using System;

namespace RootingForArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 24;
            int[] numbers = new int[SIZE];
            // string[] names = new string[SIZE];
            string[] names = {"C++ Boy", "Joe", 
                "PickleJeff", "PickleRick", 
                "Ho li Sheet", "Double Sandwich", 
                "Rachel"};
            string[] extraNames = new string[8]
            {
                "C++ Boy", "Joe",
                "PickleJeff", "PickleRick",
                "Ho li Sheet", "Double Sandwich",
                "Rachel", ""
            };

            numbers[0] = 23;
            numbers[1] = 24;
            numbers[12] = 26;
            numbers[23] = 50;
            Console.WriteLine($"1st Element with index 0: {numbers[0]}");
            Console.WriteLine($"13th Element with index 12: {numbers[12]}");
            Console.WriteLine($"21st Element with index 20: {numbers[20]}");

            Console.WriteLine($"The length of numbers array is {numbers.Length}");
            Console.WriteLine($"The length of names array is {names.Length}");

            // first element
            Console.WriteLine(names[0]);

            // last element
            Console.WriteLine(names[6]);
            Console.WriteLine(names[names.Length-1]);
        }
    }
}
