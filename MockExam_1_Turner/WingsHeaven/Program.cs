using System;

namespace WingsHeaven
{
    class Program
    {
        static void Main(string[] args)
        {
            const double DISCOUNT = .18;
            const double SALES_TAX = 0.08;
            const double BONELESS_WINGS_COST = 7.99;
            const double TRADITIONAL_WINGS_COST = 9.99;
            const double COMBO_WINGS_COST = BONELESS_WINGS_COST + TRADITIONAL_WINGS_COST;

            const double BUFFALO_SAUCE_COST = .29;
            const double MILD_SAUCE_COST = .39;
            const double BBQ_SAUCE_COST = BUFFALO_SAUCE_COST;


            const double WAFFLE_FRIES_COST = 3.49;
            const double ONION_RINGS_COST = 2.49;
            const double BOTH_SIDES_COST = 5.98;

            string typeOfWings = "";
            string typeOfSauce = "";
            string typeOfSide = "";
            double subtotal = 0;
            Console.Write($"MENU:\n\t1. Boneless Wings {BONELESS_WINGS_COST:C}\n\t2. Traditional Wings ({TRADITIONAL_WINGS_COST:C})\n\t3. Both COMBO ({COMBO_WINGS_COST})\n\t4. Exit\nEnter your preferred type of wings here (1, 2, 3, or 4): ");

            switch (Console.ReadLine())
            {
                case "1":
                    typeOfWings = $"Boneless Wings           {BONELESS_WINGS_COST:C}";
                    subtotal += BONELESS_WINGS_COST;
                    break;
                case "2":
                    typeOfWings = $"Traditional Wings           {TRADITIONAL_WINGS_COST:C}";
                    subtotal += TRADITIONAL_WINGS_COST;
                    break;
                case "3":
                    typeOfWings = $"Combo Wings           {COMBO_WINGS_COST:C}";
                    subtotal += COMBO_WINGS_COST - (COMBO_WINGS_COST * DISCOUNT);
                    break;
                case "4":
                    Console.WriteLine("\nThank you for visiting us");
                    Environment.Exit(0);
                    break;
            }

            Console.Write($"\n\n\t1. Buffalo Sauce {BONELESS_WINGS_COST:C}\n\t2. Mild Sauce ({TRADITIONAL_WINGS_COST:C})\n\t3. BBQ Sauce ({COMBO_WINGS_COST})\n\t4. No Sauce -- plain (no charge)\nEnter your preferred type of sauce here (1, 2, 3, or 4): ");

            switch (Console.ReadLine())
            {
                case "1":
                    typeOfSauce = $"Buffalo Sauce          {BUFFALO_SAUCE_COST:C}";
                    subtotal += BUFFALO_SAUCE_COST;
                    break;
                case "2":
                    typeOfSauce = $"Mild Sauce          {MILD_SAUCE_COST:C}";
                    subtotal += MILD_SAUCE_COST;
                    break;
                case "3":
                    typeOfSauce = $"BBQ Sauce          {BBQ_SAUCE_COST:C}";
                    subtotal += BBQ_SAUCE_COST;
                    break;
                case "4":
                    typeOfSauce = $"Plain         No Charge";
                    subtotal += 0;
                    break;
            }

            Console.Write($"\n\n\t1. Waffle Fries {WAFFLE_FRIES_COST:C}\n\t2. Onion Rings ({ONION_RINGS_COST:C})\n\t3. Both ({BOTH_SIDES_COST})\nEnter your preferred type of wings here (1, 2, or 3): ");

            switch (Console.ReadLine())
            {
                case "1":
                    typeOfSide = $"Waffle Fries            {BBQ_SAUCE_COST:C}";
                    subtotal += WAFFLE_FRIES_COST;
                    break;
                case "2":
                    typeOfSide = $"Onion Rings         {BBQ_SAUCE_COST:C}";
                    subtotal += ONION_RINGS_COST;
                    break;
                case "3":
                    typeOfSide = $"Both Sides          {BBQ_SAUCE_COST:C}";
                    subtotal += BOTH_SIDES_COST;
                    break;
            }

            double tax = subtotal * SALES_TAX;
            double total = subtotal + tax;


            Console.WriteLine("*** HEAVENLY WINGS ***");
            Console.WriteLine(typeOfWings);
            Console.WriteLine(typeOfSauce);
            Console.WriteLine(typeOfSide);
            Console.WriteLine($"        Subtotal: {subtotal:C}");
            Console.WriteLine($"             Tax: {tax:C}");
            Console.WriteLine($"           Total: {total:C}");


            Console.WriteLine("\n\nTHANK YOU");
        }
    }
}
