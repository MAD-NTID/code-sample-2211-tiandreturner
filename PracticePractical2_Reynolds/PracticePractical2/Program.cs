using System;

namespace PracticePractical2 {
    /*
     * Program:     Practice Practical 1
     * Author:      Prof. R.
     * Date:        23 October 2021
     * Summary:     Simple program allowing the user to enter data for "alien sightings," then
     *              provide reporting based upon that data.
     */

    class Program {

        const ConsoleColor RED = ConsoleColor.Red;
        const ConsoleColor CYAN = ConsoleColor.Cyan;
        const ConsoleColor YELLOW = ConsoleColor.Yellow;
        const ConsoleColor GREEN = ConsoleColor.Green;
        const ConsoleColor DKGREEN = ConsoleColor.DarkGreen;

        static Alien[] aliens = new Alien[0];

        /// <summary>
        /// Main entry point for the program
        /// </summary>
        /// <param name="args">Command line parameters provided</param>
        static void Main(string[] args) {

            int choice= 0;

            DisplayHeading();

            while (true) {
                choice = GetMainMenuChoice();

                switch (choice) {

                    case 1:
                        EnterASighting();
                        break;
                    case 2:
                        DisplayAllSightings();
                        break;
                    case 3:
                        FilterBySpecies();
                        break;
                    case 4:
                        DisplayRecordCount();
                        break;
                    case 5:
                        ExitProgram();
                        break;
                }

            }
        }
        /// <summary>
        /// Displays the heading for the user's interface.  Displays in Dark Green.
        /// </summary>
        public static void DisplayHeading() {
            Utility.DisplayText("MAD4UFOS Data Collection System", DKGREEN);
            Utility.DisplayText(DateTime.Now.ToString(), DKGREEN);
        }

        /// <summary>
        /// Displays the main menu and captures user input.  Input is validated to ensure it is
        /// numeric (int) and between 1 and 5
        /// </summary>
        /// <returns>int value between 1 and 5 reflecting the user's choice</returns>
        public static int GetMainMenuChoice() {
            int selection;
            while (true) { 
                Utility.DisplayText("\nMain Menu", YELLOW);
                Utility.DisplayText("=========", YELLOW);
                Utility.DisplayText("  1. Enter a sighting", CYAN);
                Utility.DisplayText("  2. Display all sightings", CYAN);
                Utility.DisplayText("  3. Display sightings filtered by species", CYAN);
                Utility.DisplayText("  4. Display Record Count", CYAN);
                Utility.DisplayText("  5. Exit", CYAN);
                Utility.DisplayText("Enter your selection (1-5): ", YELLOW, false);
                if ( ! ( int.TryParse(Console.ReadLine(), out selection )) ){
                    Utility.DisplayText("  ==>Please enter a numeric value between 1 and 5\n", RED);
                    continue;
                }
                if ( selection < 1 || selection > 5) {
                    Utility.DisplayText("  ==>Please enter a numeric value between 1 and 5\n", RED);
                    continue;
                }
                break;
            }
            return selection;
        }
        /// <summary>
        /// Collects data from user for a single alien sighting.  If any field is empty/invalid, it
        /// returns without creating a new entry.
        /// </summary>
        public static void EnterASighting() {
            string species;
            string date;
            string location;

            // Get the species name -- on invalid entry display error and exit
            Utility.DisplayText("\nEnter the species (Cockroach, Cricket, or Octo): ", YELLOW, false);
            species = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(species)) {
                Utility.DisplayText("  ==>You must enter a species name!\n", RED);
                return;
            }
            if (! ( species.ToUpper() == "COCKROACH" || species.ToUpper() == "CRICKET" || species.ToUpper() == "OCTO")) {
                Utility.DisplayText("  ==>You must enter 'Cockroach', 'Cricket', or 'Octo'\n",RED);
                return;
            }
            Utility.DisplayText("\nEnter the date of the sighting as mm/dd/yyyy: ", YELLOW, false);
            date = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(date)) {
                Utility.DisplayText("  ==>You must enter a date as mm/dd/yyyy\n", RED);
                return;
            }
            Utility.DisplayText("\nEnter the location of the sighting: ", YELLOW, false);
            location = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(location)) {
                Utility.DisplayText("  ==>You must enter a location for the sighting\n", RED);
                return;
            }

            Array.Resize(ref aliens, aliens.Length + 1);
            aliens[aliens.Length - 1] = new Alien(species, date, location);

            Utility.DisplayText("One new sighting added...\n", CYAN);

        }
        /// <summary>
        /// Produces a formatted list of all sightings.  The sighting count is displayed at the end of the list.
        /// Note:  The format string for the list is held as a property in the alien class.
        /// </summary>
        public static void DisplayAllSightings() {

            // Is there anything to display?
            if ( aliens.Length == 0 ) {
                Utility.DisplayText("\n  ==>There are no sightings to display\n", RED);
                return;
            }

            // display the headings
            string layout = aliens[0].Layout;
            Utility.DisplayText(string.Format("\n"+layout, "Species", "Date", "Location"), GREEN);
            Utility.DisplayText(string.Format(layout, "----------", "----------", "------------------"), GREEN);

            // Loop away
            for ( int index = 0; index < aliens.Length; index++ ) {
                Utility.DisplayText(aliens[index].ToString(), CYAN);
            }

            Utility.DisplayText($"  ==>{aliens.Length} records displayed\n", GREEN);

        }

        public static void DisplayRecordCount() {
            Utility.DisplayText($"  ==>There are currently {aliens.Length} sighting on file\n", GREEN);
        }

        public static void ExitProgram() {
            char confirm;

            Utility.DisplayText("\nDo you really want to exit?  Press 'Y' to confirm: ", CYAN, false);
            confirm = Console.ReadLine().ToUpper()[0];
            if (confirm == 'Y') {
                Utility.DisplayText("Thank you for using the MAD4UFOS recording system.  Goodbye.", YELLOW);
                Environment.Exit(0);
            }
        }

        public static void FilterBySpecies() {
            string species;
            Utility.DisplayText("\nEnter the alien species to list: ", CYAN, false);
            species = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(species)) {
                Utility.DisplayText(" ==>You must enter a species name/n",RED);
                return;
            }
            if ( aliens.Length == 0 ) {
                Utility.DisplayText(" ==>There are no sightings on file/n", RED);
                return;
            }
            string layout = aliens[0].Layout;
            Utility.DisplayText(string.Format("\n" + layout, "Species", "Date", "Location"), GREEN);
            Utility.DisplayText(string.Format(layout, "----------", "----------", "------------------"), GREEN);

            // Loop away
            int counter = 0;
            for (int index = 0; index < aliens.Length; index++) {
                if (aliens[index].Name.ToUpper() == species.ToUpper()) {
                    Utility.DisplayText(aliens[index].ToString(), CYAN);
                    counter++;
                }
            }

            Utility.DisplayText($"  ==>{counter} records displayed\n", GREEN);

        }
    }
}
