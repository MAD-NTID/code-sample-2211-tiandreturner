using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            Console.WriteLine("While loop");
            while(index < 1)
            {
                Console.WriteLine($"index: {index}");
                index++;
            }


            Console.WriteLine("Do-While loop");
            do
            {
                Console.WriteLine($"index: {index}");
                index++;
            } while (index < 1) ;
        }


    }
}
