using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiloGameConsole
{
    internal static class HiloGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new();
        private static int currentNumber = random.Next(MAXIMUM);

        public static int GetPot { get; private set; } = 30;

        public static void Guess(bool higher)
        {
            Console.WriteLine($"Enter your guessed from 1 to {MAXIMUM}: ");
            string? playerChoice = Console.ReadLine();
            int player = int.TryParse(playerChoice, out int result) ? result : 0;
            if (higher && player >= currentNumber)
            {
                Console.WriteLine($"You guessed right!");
                GetPot += 3;
            }
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong");
                GetPot -= 5;
            }
            currentNumber = player;
            Console.WriteLine($"The current number is {currentNumber}");
        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half)
            {
                Console.WriteLine($"The number is at least {half}");
            }
            else
            {
                Console.WriteLine($"The number is at most {half}");
                GetPot -= 5;
            }
        }
    }
}