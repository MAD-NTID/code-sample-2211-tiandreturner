using System;

namespace ScopingMethods
{
    class Program
    {
        //static string message = "";
        static void Main(string[] args)
        {
            string message = "Hello students!";
            //Display();
            Display(message);
            Display(message, 5);
            
            //Display(message, 5, 5);
            Console.WriteLine($"Message in main: {message}");

            int total = SumAndAverage(13, 4, out double avg);
            Console.WriteLine($"total: {total}\nAverage of Total: {avg}");

            Console.WriteLine($"total: {Sum(n1: 13, n2: 4)}");
        }

        static int SumAndAverage(int n1, int n2, out double average)
        {
            average = (n1 + n2) / 2.0;
            return n1 + n2;
        }

        static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        static void Display(string message)
        {
            Console.WriteLine($"Message in Display: {message}");
        }

        static void Display(string message, int amountOfTime = 3)
        {
            for (int i = 0; i < amountOfTime; i++)
            {
                Console.WriteLine($"Message in Overloaded Display: {message}");
            }
        }

        //static void Display(string message, int nouse, int amountOfTime =3)
        //{
        //    for (int i = 0; i < amountOfTime; i++)
        //    {
        //        Console.WriteLine($"Message in Overloaded Display: {message}");
        //    }
        //}
    }
}
