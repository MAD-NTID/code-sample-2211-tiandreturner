using System;

namespace PracticeWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display();
            //Display("Hello World");

            //PromptUser("Enter your first name: ");
            //Console.Write("Enter your first name: ");
            //string firstName = Console.ReadLine();
            string firstName = PromptUser("Enter your first name: ");
            string reverseString = Back(firstName);
            Display(reverseString);

            //Back(firstName);
            //char[] array = firstName.ToCharArray();
            //string reverseString = "";

            //for (int index = array.Length -1; index >= 0; index--)
            //{
            //    reverseString += array[index];
            //}

            //Display(reverseString);

            //PromptUser("Enter your last name: ");
            string lastName = PromptUser("Enter your last name: ");
            reverseString = Back(lastName);
            Display(reverseString);
            //Back(lastName);
            //array = lastName.ToCharArray();
            //reverseString = "";

            //for (int index = array.Length - 1; index >= 0; index--)
            //{
            //    reverseString += array[index];
            //}

            //Display(reverseString);

            //PromptUser("Enter your hometown: ");
            string city = PromptUser("Enter your hometown: ");
            //reverseString = Back(city);
            //Display(reverseString);
            Display(Back(city));
            //Back(city);
            //array = city.ToCharArray();
            //reverseString = "";

            //for (int index = array.Length - 1; index >= 0; index--)
            //{
            //    reverseString += array[index];
            //}

            //Display(reverseString);

            //PromptUser("Enter your favorite hobby: ");
            string hobby = PromptUser("Enter your favorite hobby: ");

            //Back(hobby);

            //array = hobby.ToCharArray();
            //reverseString = "";

            //for (int index = array.Length - 1; index >= 0; index--)
            //{
            //    reverseString += array[index];
            //}

            //Display(reverseString);

            Display(firstName, ConsoleColor.Blue);
            Display(lastName);
            Display(city, ConsoleColor.Green);
            Display(hobby);


        }

        //private static void Back(string stringValue)
        //{
        //    char[] array = stringValue.ToCharArray();
        //    string reverseString = "";

        //    for (int index = array.Length - 1; index >= 0; index--)
        //    {
        //        reverseString += array[index];
        //    }

        //    Display(reverseString);
        //}

        private static string Back(string stringValue)
        {
            char[] array = stringValue.ToCharArray();
            string reverseString = "";

            for (int index = array.Length - 1; index >= 0; index--)
            {
                reverseString += array[index];
            }

            return reverseString;
        }

        private static string PromptUser(string prompt)
        {
            Console.Write(prompt);
            string data = Console.ReadLine();
            return data;
        }

        //private static string GetUserInput()
        //{
        //    return Console.ReadLine();
        //}

        private static void Display()
        {
            Console.WriteLine("Hello World!");
        }

        private static void Display(string message)
        {
            Console.WriteLine(message);
        }

        private static void Display(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        //private static void Display(string differentMessage)
        //{
        //    Console.WriteLine(differentMessage);
        //}
    }
}
