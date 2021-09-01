using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 17;
            int secNumber = 5;
            int totalNumber = number / secNumber; // integer division
            double thirdNumber = 5;
            double totalDivNumber = number / thirdNumber; // reg division
            Console.WriteLine($"{number} / {secNumber} = {totalNumber}");
            Console.WriteLine($"{number} / {thirdNumber} = {totalDivNumber}");

            double randomNumber = 12;
            double randomNumber1 = 100;
            double totalNumber2 = randomNumber / randomNumber1;
            Console.WriteLine($"Double value: {totalNumber2}");
            Console.WriteLine($"Integer value: {(int)totalNumber2}");

            const int MY_LUCKY_NUMBER = 11; // this is a constant
           
        }
    }
}
