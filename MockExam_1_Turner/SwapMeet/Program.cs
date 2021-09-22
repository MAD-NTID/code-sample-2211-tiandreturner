using System;

namespace SwapMeet
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ALL_DISK_PRICE = 25.75;
            const string ERROR_MESSAGE = "\nError: The value you entered is invalid... exiting";
            const string PROGRAM_END = "\nProgram End... exiting";
            int numOfDisk = 0;
            double total = 0;
            
            Console.Write("How many disk drives are in the current invertory? ");

            if(!int.TryParse(Console.ReadLine(), out numOfDisk))
            {
                Console.WriteLine(ERROR_MESSAGE);
                Environment.Exit(0);
            }

            Console.Write("MENU:\n\t1. Display current inventory value\n\t2. Buy disks from Disks4Cheap\n\t3. Sell disks from Disks4Cheap\n\t4. Exit\nEnter your choice here (1, 2, 3, or 4): ");

            switch(Console.ReadLine())
            {
                case "1":
                    total = numOfDisk * ALL_DISK_PRICE;
                    Console.WriteLine($"\nInventory Count: {numOfDisk}\tValue: {total:C}");
                    Console.WriteLine(PROGRAM_END);
                    break;
                case "2":
                    Console.Write("\nHow many disks do you want to purchase? ");
                    int numOfDisksToPurchase = int.Parse(Console.ReadLine());
                    //numOfDisk += numOfDisksToPurchase;
                    //total = numOfDisk * ALL_DISK_PRICE;
                    total = (numOfDisk + numOfDisksToPurchase) * ALL_DISK_PRICE;
                    Console.WriteLine($"\nInventory Count: {numOfDisk}\tValue: {total:C}");
                    Console.WriteLine(PROGRAM_END);
                    break;
                case "3":
                    Console.Write("\nHow many disks do you want to sell? ");
                    int numOfDisksToSell = int.Parse(Console.ReadLine());
                    numOfDisk -= numOfDisksToSell;
                    total = numOfDisk * ALL_DISK_PRICE;
                    //total = (numOfDisk + numOfDisksToPurchase) * ALL_DISK_PRICE;
                    Console.WriteLine($"\nInventory Count: {numOfDisk}\tValue: {total:C}");
                    Console.WriteLine(PROGRAM_END);
                    break;
                case "4":
                    Console.WriteLine("\nThank you for visiting us");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(ERROR_MESSAGE);
                    break;
            }

            
        }
    }
}
