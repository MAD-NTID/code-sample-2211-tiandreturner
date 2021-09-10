using System;

namespace Commission_
{
    class Program
    {
        static void Main(string[] args)
        {

            const double COMMISSION_RATE = .07;
            

            // input
            Console.Write("Saleperson: ");
            string name = Console.ReadLine();

            Console.Write("Total Sales: ");
            double totalSale = double.Parse(Console.ReadLine());

            double total = 0;
            //double total;
            // process
            if (totalSale >= 10000)
            {
                total = totalSale * COMMISSION_RATE;
            }

            //if (totalSale < 10000)
            //{
            //    total = 0;
            //}

            // output
            Console.WriteLine($"{name}'s commission: {total:C}");
        }
    }
}
