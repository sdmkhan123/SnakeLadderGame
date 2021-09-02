using System;

namespace SnakeLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            int position = 0;
            Random random = new Random();
            int diceOutcome = random.Next(1, 7);
        }
    }
}
