using System;

namespace RandomizeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            const int WINNING_TOTAL_NUMBER = 15;
            Random random = new Random();
            int dice1, dice2 = random.Next(1, 6), dice3;
            int bonus = 0;

            dice1 = random.Next(1, 6);
            dice3 = random.Next(1, 6);

            int total = dice1 + dice2 + dice3;

            Console.WriteLine($"Dice #1: {dice1}");
            Console.WriteLine($"Dice #2: {dice2}");
            Console.WriteLine($"Dice #3: {dice3}");

            if (dice1 == dice2 || dice2 == dice3 || dice1 == dice3 )
            {
                bonus += 2;
            }

            if (dice1 == dice2 && dice2 == dice3 && dice1 == dice3)
            {
                bonus += 6;
            }

            Console.WriteLine($"The final amount of the total score with bonus points: {total + bonus}");
            if((total + bonus) >= WINNING_TOTAL_NUMBER)
            {
                Console.WriteLine("You WON!");
            }
            else
            {
                Console.WriteLine("Sorry, you lost. BYE-BYE.");
            }

        }
    }
}
