using System;

namespace SnakeLadderGame
{
    class Program
    {
        public const int win = 100;
        public const int ladder = 1;
        public const int snake = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            int position = 0;
            Random random = new Random();
            int diceOutcome = random.Next(1, 7);
            int checkOptions = random.Next(0, 3);
            switch (checkOptions)
            {
                case ladder:
                    position += diceOutcome;
                    break;
                case snake:
                    position -= diceOutcome;
                    break;
                default:
                    break;
            }
        }
    }
}
