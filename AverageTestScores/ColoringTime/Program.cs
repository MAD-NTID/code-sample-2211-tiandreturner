using System;

namespace ColoringTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a program that changes color on the fly
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("red");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("green");


        }
    }
}
