using System;

namespace MockExam_1_MasterSolution {
    class Program {
        /* Title:       Swap Meet
         * Date:        18 September 2005
         * Author:      Mark Reynolds
         * Description: Problem 1 for Mock Exam 1.  Simple calculations and data validation.  Could use else/if or switch.
         */
        static void Main(string[] args) {
            const double DISKVALUE = 25.75;
            const string COMPANYNAME = "Disks4Cheap";
            const string BADVALUE = "\nError: The value you entered is invalid... exiting\n";
            const string CLEANEXIT = "\nProgram End... exiting\n";
            const string MENU = "\nMENU:\n\t1. Display current inventory value\n\t2. Buy disks from Disks4Cheap\n\t3. Sell disks to Disks4Cheap\n\t4. Exit";
            const string INVENTORY = "\nInventory Count: {0,-3}     Value: {1,6:C}";
            
            int inventoryCount = 0;
            int saleCount = 0;
            int menuSelection = 0;
            
            // Display the header 
            Console.Clear();
            Console.WriteLine($"\n***{COMPANYNAME}***\n");

            // prompt for the current inventory count
            Console.Write("How many disk drives are in the current inventory? ");
            if ( !int.TryParse(Console.ReadLine(), out inventoryCount)) {
                Console.WriteLine(BADVALUE);
                Environment.Exit(0);
            }

            // display the menu
            Console.WriteLine(MENU);
            Console.Write("Enter your choice here (1, 2, 3, or 4): ");
            if (!int.TryParse(Console.ReadLine(), out menuSelection)) { 
                Console.WriteLine(BADVALUE);
                Environment.Exit(1);
            }

            if (menuSelection < 1 || menuSelection > 4) {
                Console.WriteLine(BADVALUE);
                Environment.Exit(3);
            }

            switch (menuSelection) {
                case 1:                 // show inventory
                    Console.WriteLine(INVENTORY, inventoryCount, inventoryCount * DISKVALUE);
                    break;
                case 2:                 // buy disks
                    Console.Write("\nHow many disks do you want to purchase?  ");
                    if (!int.TryParse(Console.ReadLine(), out saleCount)) {
                        Console.WriteLine(BADVALUE);
                        Environment.Exit(4);
                    }
                    inventoryCount -= saleCount;
                    Console.WriteLine(INVENTORY, inventoryCount, inventoryCount * DISKVALUE);
                    break;
                case 3:
                    Console.Write("\nHow many disks do you want to sell?  ");
                    if (!int.TryParse(Console.ReadLine(), out saleCount)) {
                        Console.WriteLine(BADVALUE);
                        Environment.Exit(4);
                    }
                    inventoryCount += saleCount;
                    Console.WriteLine(INVENTORY, inventoryCount, inventoryCount * DISKVALUE);
                    break;
                case 4:
                    Console.WriteLine("\nThank you for visiting us");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(BADVALUE);
                    break;
            }
            // display an exit message
            Console.WriteLine(CLEANEXIT);
        }
    }
}
