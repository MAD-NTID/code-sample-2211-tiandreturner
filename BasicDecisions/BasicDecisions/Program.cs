using System;

/**
 * Name: Professor Tiandre Turner
 * Course: NMAD.180.03 -- Programming Fundamental I
 * Date: 09/08/2021
 * Description: Showing the basic decisions
 * Caveats: None
*/
namespace BasicDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN_DRIVING_AGE = 16;
            const int MAX = 30;
            const int MIN = 0;

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

          

            if (age < MIN)
            {
                Console.WriteLine("Cannot continue if the age you entered is less than the minimum age.");
            }

            if(age < MAX && age > MIN)
            {
                Console.WriteLine("You're younger than 30!");
                if (age >= MIN_DRIVING_AGE)
                {
                    Console.Write("Do you have a license: ");
                    string license = Console.ReadLine();

                    Console.Write("Do you have a permit: ");
                    string permit = Console.ReadLine();

                    if(license == "yes" || permit == "yes")
                    {
                        Console.WriteLine("Congrats, you can drive on the road!");
                    }

                    //if(permit == "yes")
                    //{
                    //    Console.WriteLine("Congrats, you can drive on the road?");
                    //}

                    //if(permit == "no")
                    //{
                    //    Console.Write("Do you have a license: ");
                    //    string license = Console.ReadLine();

                    //}
                }
                
            }

            if(age > MAX)
            {
                Console.WriteLine("You're much older! Gosh!");
            }
        }
    }
}
