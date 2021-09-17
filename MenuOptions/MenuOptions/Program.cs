using System;

namespace MenuOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "1. Create a new sandwich\n" +
                "2. Edit a sandwich\n" +
                "3. Remove a sandwich\n" +
                "4. Bundle sandwiches\n" +
                "5. Exit program\n";

            Console.Write($"{menu}\nEnter option: ");

            //string input = Console.ReadLine();
            //int option = 0;
            //bool inputSuccess = int.TryParse(input, out option);

            //if(!inputSuccess)
            //{
            //    Console.WriteLine("Write an error message");
            //    Environment.Exit(0);
            //}

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Create a new sandwich! yummy!");
                    break;
                case "2":
                    Console.WriteLine("Edit a sandwich! yummy!");
                    break;
                case "3":
                    Console.WriteLine("removing a sandwich! boo!");
                    break;
                case "4":
                    Console.WriteLine("bundling a sandwich! yummy!");
                    break;
                case "5":
                    Console.WriteLine("Exiting the program");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("I have no idea what do you want me to do with this!");
                    break;
            }

            //switch (option)
            //{
            //    case 1:
            //        Console.WriteLine("Create a new sandwich! yummy!");
            //        break;
            //    case 2:
            //        Console.WriteLine("Edit a sandwich! yummy!");
            //        break;
            //    case 3:
            //        Console.WriteLine("removing a sandwich! boo!");
            //        break;
            //    case 4:
            //        Console.WriteLine("bundling a sandwich! yummy!");
            //        break;
            //    case 5:
            //        Console.WriteLine("Exiting the program");
            //        Environment.Exit(0);
            //        break;
            //    default:
            //        Console.WriteLine("I have no idea what do you want me to do with this!");
            //        break;
            //}

            //string menu = "Do you want to continue? (y/n): ";
            //Console.Write(menu);
            //string input = Console.ReadLine();

            //if(input == "y" || input == "Y")
            //{
            //     Console.WriteLine("Yes! I want to continue");
            //}


            //switch(Console.ReadLine().ToLower())
            //{
            //    case "y":
            //    case "Y":
            //        Console.WriteLine("Yes! I want to continue");
            //        break;
            //    case "n":
            //        Console.WriteLine("Nah homie, I aint going to continue");
            //        break;
            //}
        }
    }
}
