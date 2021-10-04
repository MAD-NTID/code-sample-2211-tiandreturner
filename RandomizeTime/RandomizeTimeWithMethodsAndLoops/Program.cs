using System;

namespace RandomizeTimeWithMethodsAndLoops
{
    class Program
    {
        static Random random = new Random();
       // static int dice1, dice2, dice3;
        static void Main(string[] args)
        {
            const int WINNING_TOTAL_NUMBER = 15;
           

            string input = "";
            do
            {

                int dice1, dice2 = GetRandomNumber(), dice3;
                int bonus = 0;

                dice1 = GetRandomNumber();
                dice2 = GetRandomNumber();
                dice3 = GetRandomNumber();

                int total = GetTotalOfDices(dice1,dice2, dice3);

                Console.WriteLine($"Dice #1: {dice1}");
                Console.WriteLine($"Dice #2: {dice2}");
                Console.WriteLine($"Dice #3: {dice3}");

                if (dice1 == dice2 || dice2 == dice3 || dice1 == dice3)
                {
                    bonus += 2;
                }

                if (dice1 == dice2 && dice2 == dice3 && dice1 == dice3)
                {
                    bonus += 6;
                }

                Console.WriteLine($"The final amount of the total score with bonus points: {total + bonus}");
                if ((total + bonus) >= WINNING_TOTAL_NUMBER)
                {
                    //WinnerMessage("You WON!");
                    Message("You WON!");
                }
                else
                {
                    Message("Sorry, you lost. BYE-BYE.");
                    //LoserMessage();
                }

                Console.Write("Do you want to continue? (Y/N): ");
                input = Console.ReadLine();
            } while (input != "N");
        }

        private static int TotalOfThree()
        {
            return 1 + 2 + 3;
        }

        private static void Message(string message)
        {
            Console.WriteLine(message);
        }

        private static int GetRandomNumber()
        {
            int getRandomNumber = random.Next(1, 6);
            return getRandomNumber;
        }

        private static double GetTotalOfDices(int dice1,int dice2,int dice3)
        {
            double total = dice1 + dice2 + dice3;
            return total;
        }

        //private static void WinnerMessage()
        //{
        //    Console.WriteLine("You WON!");
        //}

        //private static void LoserMessage()
        //{
        //    Console.WriteLine("Sorry, you lost. BYE-BYE.");
        //}


    }
}
