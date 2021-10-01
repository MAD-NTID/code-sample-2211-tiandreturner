using System;

namespace ArraysWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];
            numbers[0] = 10;
            numbers[1] = 8;
            numbers[2] = 67;
            numbers[3] = 18;
            numbers[4] = 31;
            numbers[5] = 24;
            numbers[6] = 11;

            string[] letters = { "z", "c", "x", "b", "y", "m", "e" };

            string[] names = {"Leeon", "Anthony",
                "Juan", "Austyn",
                "Joseph", "Shahria", "Professor Turner"
            };

            //int pickleRickFavNum = numbers[3];
            //Console.WriteLine($"Pickle Rick's favorite number: {pickleRickFavNum}");


            //Console.WriteLine($"Favorite Number: {numbers[0]}");
            //Console.WriteLine($"Favorite Number: {numbers[1]}");
            //Console.WriteLine($"Favorite Number: {numbers[2]}");
            //Console.WriteLine($"Favorite Number: {numbers[3]}");
            //Console.WriteLine($"Favorite Number: {numbers[4]}");
            //Console.WriteLine($"Favorite Number: {numbers[5]}");
            //Console.WriteLine($"Favorite Number: {numbers[6]}");

            //Console.WriteLine("Before sorting");
            //Console.WriteLine("Before reversing");
            //for (int index = 0; index <= numbers.Length - 1; index++) or
            Console.WriteLine("using for");
            //for (int index = 0; index < names.Length; index++)
            //{
            //    //Console.WriteLine($"index: {index}");
            //    Console.WriteLine($"{index + 1}. {names[index]}");
            //}


            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine($"{names[index]}'s favorite number is {numbers[index]}");
            }


           // Console.WriteLine("Using foreach");
            #region foreach loop
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine($"Favorite Number: {number}");
            //}
            //int index = 1;
            //foreach (string name in names)
            //{
            //    Console.WriteLine($"{index++}.{name}");
            //}

            #endregion

            //Console.WriteLine("After sorting");
            //Array.Sort(numbers);

            Console.WriteLine("After reversing");
            //Array.Reverse(numbers);

            //for (int index = 0; index < numbers.Length; index++)
            //{
            //    Console.WriteLine($"Favorite Number: {numbers[index]}");
            //}
            //int[] numbers = new int[7] { 10, 8, 67, 18, 31, 24, 11 };

            //int[] numbers = { 10, 8, 67, 18, 31, 24, 11 };
        }
    }
}
