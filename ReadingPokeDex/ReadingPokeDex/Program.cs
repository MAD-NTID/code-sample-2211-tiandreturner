using System;
using System.IO;


namespace ReadingPokeDex
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the file name: ");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                StreamReader reader = new StreamReader(fileName);
                //string line;

                //while ((line = reader.ReadLine()) != null)
                //{
                //    Console.WriteLine(line);
                //}

                while(!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }

                reader.Close();
            }
            else
            {
                Console.WriteLine("The file you looked for does not exist");
            }
        }
    }
}
