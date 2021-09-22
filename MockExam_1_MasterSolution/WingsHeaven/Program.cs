using System;

namespace WingsHeaven {
    class Program {

        /* Title:       Wings Heaven
         * Date:        18 September 2021
         * Author:      Mark Reynolds
         * Description: Simple program to allow the user to make selections of wing type, sauces, and side dishes.
         *              Per the requirements, data testing is not required.
         * Caveat:      The value for a "both types" order is not included.  It should be calculated.  Including the
         *              value runs the risk of not being updated as the wings or sides prices changes.
         *              There's a sneaky trick here:  We're building the receipt as we go along instead of stashing
         *              selections in other variables.  By doing this, we only really need a receipt variable, and
         *              a variable to hold the running total.
         */
        static void Main(string[] args) {
            // establish constants
            const double BONELESS_WINGS = 7.99;
            const double TRADITIONAL_WINGS = 9.99;
            const double DISCOUNT_RATE = .18;
            const double BUFFALO_SAUCE = .29;
            const double MILD_SAUCE = .39;
            const double BBQ_SAUCE = .29;
            const double WAFFLE_FRIES = 3.49;
            const double ONION_RINGS = 2.49;
            const string RESTAURANT = "\n*** HEAVENLY WINGS ***\n";
            const string MENU_FORMAT = "   {0}. {1,-15} {2,10:C}";
            const string PROMPT = "Enter your selection: ";
            const string RECEIPT_FORMAT = "{0,-20} {1,11:c}\n";
            const double TAX_RATE = .08;

            string receipt;
            double total = 0.0;

            // prepare the receipt
            receipt = RESTAURANT;
            // Let's get the first menu up and running

            Console.WriteLine(RESTAURANT);
            Console.WriteLine("Type of wings:");
            Console.WriteLine(MENU_FORMAT, 1, "Boneless", BONELESS_WINGS);
            Console.WriteLine(MENU_FORMAT, 2, "Traditional", TRADITIONAL_WINGS);
            Console.WriteLine(MENU_FORMAT, 3, "Both", BONELESS_WINGS + TRADITIONAL_WINGS);
            Console.Write(PROMPT);
            switch ( int.Parse( Console.ReadLine() ) ) {
                case 1:                 // only boneless
                    total += BONELESS_WINGS;
                    receipt += string.Format(RECEIPT_FORMAT, "Boneless Wings", BONELESS_WINGS);
                    break;
                case 2:                 // only traditional
                    total += TRADITIONAL_WINGS;
                    receipt += string.Format(RECEIPT_FORMAT, "Traditional Wings", TRADITIONAL_WINGS);
                    break;
                case 3:
                    total += BONELESS_WINGS + TRADITIONAL_WINGS;
                    receipt += string.Format(RECEIPT_FORMAT, "Both Wings", BONELESS_WINGS + TRADITIONAL_WINGS);
                    total -= ( ( BONELESS_WINGS + TRADITIONAL_WINGS ) * DISCOUNT_RATE );
                    receipt += string.Format( RECEIPT_FORMAT, "   Discount (18%)",
                                (-1 * ( BONELESS_WINGS + TRADITIONAL_WINGS ) * DISCOUNT_RATE ) );
                    break;
                default:
                    Console.WriteLine("This should never happen");
                    Environment.Exit(1);
                    break;
            }
            // Now, let's check on the sauce
            Console.WriteLine("\nWhat kind of sauce?");
            Console.WriteLine(MENU_FORMAT, 1, "Buffalo Sauce", BUFFALO_SAUCE);
            Console.WriteLine(MENU_FORMAT, 2, "Mild Sauce", MILD_SAUCE);
            Console.WriteLine(MENU_FORMAT, 3, "BBQ Sauce", BBQ_SAUCE);
            Console.WriteLine("   {0}. {1,-15} {2,12}", 4, "Plain", "No Charge");
            Console.Write(PROMPT);
            switch ( int.Parse ( Console.ReadLine() ) ) {
                case 1:
                    total += BUFFALO_SAUCE;
                    receipt += string.Format(RECEIPT_FORMAT, "Buffalo Sauce", BUFFALO_SAUCE);
                    break;
                case 2:
                    total += MILD_SAUCE;
                    receipt += string.Format(RECEIPT_FORMAT, "Mild Sauce", MILD_SAUCE);
                    break;
                case 3:
                    total += BBQ_SAUCE;
                    receipt += string.Format(RECEIPT_FORMAT, "BBQ Sauce", BBQ_SAUCE);
                    break;
                case 4:
                    receipt += string.Format("{0,-20} {1,12}\n", "Plain", "No Charge");
                    break;
                default:
                    Console.WriteLine("This should never happen");
                    Environment.Exit(2);
                    break;
            }

            // let's get the side orders
            Console.WriteLine("\nDo you want a side order?");
            Console.WriteLine(MENU_FORMAT, 1, "Waffle Fries", WAFFLE_FRIES);
            Console.WriteLine(MENU_FORMAT, 2, "Onion Rings", ONION_RINGS);
            Console.WriteLine(MENU_FORMAT, 3, "Both", WAFFLE_FRIES + ONION_RINGS);
            Console.Write(PROMPT);
            switch ( int.Parse( Console.ReadLine() ) ) {
                case 1:
                    total += WAFFLE_FRIES;
                    receipt += string.Format(RECEIPT_FORMAT, "Waffle Fries", WAFFLE_FRIES);
                    break;
                case 2:
                    total += ONION_RINGS;
                    receipt += string.Format(RECEIPT_FORMAT, "Onion Rings", ONION_RINGS);
                    break;
                case 3:
                    total += WAFFLE_FRIES + ONION_RINGS;
                    receipt += string.Format(RECEIPT_FORMAT, "Fries & Rings", WAFFLE_FRIES + ONION_RINGS);
                    break;
                default:
                    Console.WriteLine("This should never happen");
                    break;
            }

            // at this point, the "total" variable holds the sub-total.  Let's stick that on the receipt
            // Trick: took the left justify off to place the literal next to the subtotal

            receipt += string.Format("{0,20} {1,11:C}\n", "Subtotal:", total);

            // add the tax
            receipt += string.Format("{0,20} {1,11:C}\n", "Tax:", total * TAX_RATE);

            // wrap it up
            receipt += string.Format("{0,20} {1,11:C}\n", "Total:", total + (total * TAX_RATE));
            receipt += "\n\n THANK YOU ";

            Console.WriteLine(receipt);

        }
    }
}
