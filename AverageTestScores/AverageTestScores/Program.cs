using System;

namespace AverageTestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name;
            string data;
            double firstScore;
            double secondScore;

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("The first score is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            //data = Console.ReadLine();
            firstScore = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("The second score is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            data = Console.ReadLine();
            secondScore = double.Parse(data);

            double average = (firstScore + secondScore) / 2;
            Console.ResetColor();
            Console.WriteLine("Hello," + name);
            Console.WriteLine("Hello,{0}", name);
            Console.WriteLine($"Hello {name}");


            Console.WriteLine("Your first score is {0}\nYour second score is {1}", 
                firstScore, secondScore);

            Console.WriteLine($"The average is {average}");

        }
    }
}
