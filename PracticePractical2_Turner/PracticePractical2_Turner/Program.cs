using System;

namespace PracticePractical2_Turner
{
    /**
     * Name: Prof. Turner
     * Course:  dsjkfajkdf
     * Date:
     * Description:
     * Caveats
     */
    class Program
    {
        static Alien[] aliens = new Alien[100];
        static void Main(string[] args)
        {
            DisplayHeader();            // display the system heading

            int choice;                 // variable holding the value entered by the user

            while (true)
            {
                choice = GetMenuSelection();    // Get user's menu selection

                switch (choice)
                {
                    case 1:                     // Enter player information
                        EnterASighting();
                        break;
                    case 2:
                        DisplayAllSightings();
                        break;
                    case 3:
                        ListBySpecies();
                        break;
                    case 4:
                        DisplayRecordCount();
                        break;
                    case 5:                     // exit
                        ExitProgram();
                        break;
                    default:
                        Console.WriteLine("The option you selected is not listed in the menu.");
                        break;
                }
            }
        }

        private static void DisplayRecordCount()
        {
            int counter = 0;
            foreach (Alien alien in aliens)
            {
                if (alien != null)
                {
                    Console.WriteLine(alien);
                    counter++;
                }
            }

            Console.WriteLine($"\t==> {counter} records displayed");
        }

        // This method will terimates the program.
        private static void ExitProgram()
        {
            Console.Write("Do you want to exit>? Press Y to exit: ");
            if (Console.ReadLine().ToUpper() == "Y")
                Environment.Exit(0);
        }

        /// <summary>
        /// 
        /// </summary>
        private static void ListBySpecies()
        {
            DisplaySightings(false);
            //if (aliens[0] == null)
            //{
            //    Console.WriteLine("No species displayed");
            //    return;
            //}

            //Console.Write("Enter the alien species to list: ");
            //string species = Console.ReadLine();

            //Console.WriteLine($"{"Species",-12}{"Date",12} Location");
            //Console.WriteLine($"{"----------",-12}{"----------",12} ------------------");

            //int counter = 0;
            //foreach (Alien alien in aliens)
            //{
            //    if (alien != null && alien.Name.ToLower() == species.ToLower())
            //    {
            //        Console.WriteLine(alien);
            //        counter++;
            //    }
            //}

            //Console.WriteLine($"\t==> {counter} records displayed");
        }

        private static void DisplaySightings(bool displayAll = true)
        {
            string species = null;
            if (aliens[0] == null)
            {
                Console.WriteLine("No species displayed");
                return;
            }

            if (!displayAll)
            {
                Console.Write("Enter the alien species to list: ");
                species = Console.ReadLine();
            }

            Console.WriteLine($"{"Species",-12}{"Date",12} Location");
            Console.WriteLine($"{"----------",-12}{"----------",12} ------------------");

            int counter = 0;
            foreach (Alien alien in aliens)
            {
                if (alien != null)
                {
                    if (displayAll || (!displayAll && alien.Name.ToLower() == species.ToLower()))
                    {
                        Console.WriteLine(alien);
                        counter++;
                    }
                }
            }

            Console.WriteLine($"\t==> {counter} records displayed");
        }

        private static void DisplayAllSightings()
        {
            DisplaySightings();
            //if(aliens[0] == null)
            //{
            //    Console.WriteLine("No species displayed");
            //    return;
            //}

            //Console.WriteLine($"{"Species", -12}{"Date", 12} Location");
            //Console.WriteLine($"{"----------",-12}{"----------",12} ------------------");

            //int counter = 0;
            //foreach(Alien alien in aliens)
            //{
            //    if (alien != null)
            //    {
            //        Console.WriteLine(alien);
            //        counter++;
            //    }
            //}

            //Console.WriteLine($"\t==> {counter} records displayed");
        }

        private static void EnterASighting()
        {
            string species = null;
            string date = null;
            string location = null;

            while(true)
            {
                Console.Write("\nEnter the species (Cockroach, Cricket, or Octo): ");

                if((species = Console.ReadLine()).Length != 0)
                {
                    break;
                }

                Console.WriteLine("  ===> You must enter a species name!");
            }

            while (true)
            {
                Console.Write("\nEnter the date of the sigthing as mm/dd/yyyy: ");

                if ((date = Console.ReadLine()).Length == 10)
                {
                    break;
                }

                Console.WriteLine("  ===> You must enter a date as mm/dd/yyyy");
            }

            Console.Write("\nEnter the location of the sighting: ");

            while ((location = Console.ReadLine()).Length == 0)
            {
                Console.WriteLine("  ===> You must enter a date as mm/dd/yyyy");
                Console.Write("Enter the location of the sighting: ");
            }


            for (int index = 0; index < aliens.Length; index++)
            {
                if(aliens[index] == null)
                {
                    aliens[index] = new Alien(species, date, location);
                    Console.WriteLine("One new sighting added...");
                    break;
                }
            }
        }

        private static int GetMenuSelection()
        {
        
            int input;
            Console.WriteLine("Main Menu");
            Console.WriteLine("=========");
            Console.WriteLine("\t1. Enter a sighting");
            Console.WriteLine("\t2. Display all sightings");
            Console.WriteLine("\t3. Display sightings filtered by species");
            Console.WriteLine("\t4. Display Record Count");
            Console.WriteLine("\t5. Exit");
            Console.Write("Enter your selection (1-5): ");

            while(!int.TryParse(Console.ReadLine(), out input))
            {
                Console.Write("Error: Invalid Input\nEnter your selection (1-5): ");
            }

            return input;
        }

        private static void DisplayHeader()
        {
            Console.Clear();
            Console.WriteLine("MAD4UFOS Data Collection System");
            Console.WriteLine(DateTime.Now.ToString());
        
        }
    }
}
