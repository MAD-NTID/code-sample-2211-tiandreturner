using System;

namespace TryParseWithSwitches
{
    class Program
    {
        static void Main(string[] args)
        {
            // use parse
            Console.Write("Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            //double money = 0;
            // use TryParse
            //int secNum = 0;
            Console.Write("Enter second number: ");

            bool isValid = int.TryParse(Console.ReadLine(), out int secNum);
            //if (int.TryParse(Console.ReadLine(), out int secNum))
            //{
            //    double money = 23;
            //    Console.WriteLine(secNum);
            //    //Console.WriteLine($"second number: {secNum}\nboolean value: {isValid}");
            //    Console.WriteLine("the value is valid");
            //}
            //else
            //{
            //    double money = 34;
            //    Console.WriteLine(secNum);
            //    //Console.WriteLine($"second number: {secNum}\nboolean value: {isValid}");
            //    Console.WriteLine("Brah, what you got me is pretty badddd");
            //}

            if (!isValid)
            {
                Console.WriteLine($"second number: {secNum}\nboolean value: {isValid}");
                Console.WriteLine("Brah, what you got me is pretty badddd");
                Environment.Exit(0);
            }

            Console.WriteLine($"second number: {secNum}\nboolean value: {isValid}");
            Console.WriteLine("the value is valid");

            Console.Write("Enter the operator: ");
            string op = Console.ReadLine();

            switch(op)
            {
                case "+":
                    Console.WriteLine($"{firstNum} + {secNum} = {firstNum + secNum}");
                    break;
                case "-":
                    Console.WriteLine($"{firstNum} - {secNum} = {firstNum - secNum}");
                    break;
                default:
                    Console.WriteLine("this operator does not exist.");
                    break;
            }

        }
    }
}
