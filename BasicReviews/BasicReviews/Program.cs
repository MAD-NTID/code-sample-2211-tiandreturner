using System;


/**
 * Name: Professor Turner
 * Date: 09/03/2021
 * Course: NMAD.180.03 -- Programming Fundamentals I
 * Description: Reviewing with the students on code demostration
 * Caveats: Hopefully none :)
 */
namespace BasicReviews
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Swimming with coders";
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            // data types

            const double SALES_TAX = 0.08;
            byte food = 3;
            int age;
            double money = 1000000.50;
            float iceCream = 30;
            string name = "MAD Students";
            long change = 100;

            age = 18;


            // string formatting
            // string interpolation 
            Console.WriteLine($"a byte with a variable name called food: {food}");
            Console.WriteLine("a byte with a variable name called food: {0}", food);
            // string concentation
            Console.WriteLine("a byte with a variable name called food: " + food);

            Console.WriteLine("Juan's dream money is $" + money);
            Console.WriteLine("Juan's dream money is {0:N}", money);
            Console.WriteLine($"Juan's dream money is {money:C}");


            double pi = 3.141592653589793238462643;
            Console.WriteLine("PI - {0:N2}", pi);
            Console.WriteLine("PI - {0:N5}", pi);
            Console.WriteLine("PI - {0:N8}", pi);

            string data;
            int number;
            Console.Write("Enter a number: ");
            data = Console.ReadLine();
            number = int.Parse(data);

            //string data = Console.ReadLine();
            //int number = int.Parse(data);

            //int number = int.Parse(Console.ReadLine());

            double floatingPoint = 29.1237;
            //int wholeNumber = Convert.ToInt32(floatingPoint);

            int wholeNumber = (int)floatingPoint;

            Console.WriteLine($"The value of floatingPoint is {floatingPoint}");
            Console.WriteLine($"The value of wholeNumber is {wholeNumber}");
            Console.WriteLine($"Number: {number}");
        }
    }
}
