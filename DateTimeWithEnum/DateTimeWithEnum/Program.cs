using System;

namespace DateTimeWithEnum
{
    public enum Days
    {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"1. Sunday\n2. Monday\n3. Tuesday\n4. Wednesday\n5. Thursday\n6. Friday\n7. Saturday\n");
            //Console.Write("Select a day: ");
            //int selection = int.Parse(Console.ReadLine());
            //Console.WriteLine((Days)selection);

            DateTime current = DateTime.Now;
            Console.WriteLine(current);
            Console.WriteLine(current.ToShortDateString());
            Console.WriteLine(current.ToShortTimeString());
            Console.WriteLine(current.ToLongTimeString());
            Console.WriteLine(current.AddDays(6).AddMonths(-4));

        }
    }
}
