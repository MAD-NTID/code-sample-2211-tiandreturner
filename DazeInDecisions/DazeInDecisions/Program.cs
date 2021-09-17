using System;

namespace DazeInDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 13;
            int y = 2;
            int z = 15;
            
            if(!(!((x > y) && !(z != x || y < z))))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
