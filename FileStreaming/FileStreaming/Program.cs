using System;
using System.Collections.Generic;
using System.IO;

namespace FileStreaming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>()
            {
                "Double Sandwich",
                "C++ Boy",
                "Ho li",
                "PickleJeff",
                "PickleRick",
                "Rae",
                "Day-dreaming boy"
            };

            StreamWriter writer = new StreamWriter("students.txt");
            
            foreach(string student in students)
            {
                writer.WriteLine(student);
                //Console.WriteLine(student);
            }

            writer.Flush();
            writer.Close();

            int number = 1;
            string line;

            StreamReader reader = new StreamReader("students.txt");
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine($"{number++} -- {line}");
            }


            foreach (string info in File.ReadLines("students.txt"))
            {
                Console.WriteLine(info);
            }
            //do
            //{
            //    Console.WriteLine($"{number++} -- {line = reader.ReadLine()}");
            //} while (line != null);

            // Console.WriteLine("Hello World!");
        }
    }
}
