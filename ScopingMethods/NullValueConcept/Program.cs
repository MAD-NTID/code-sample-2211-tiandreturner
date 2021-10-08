using System;

namespace NullValueConcept
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string[] classList = new string[10];

            while (true)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                for(int i = 0; i < classList.Length; i++)
                {
                    if(classList[i] == null)
                    {
                        classList[i] = name;
                        break;
                    }

                }
            }
        }
    }
}
