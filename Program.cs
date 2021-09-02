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
            int diceCount = 0;
            while (position < win)
            {
                Random random = new Random();
                int diceOutcome = random.Next(1, 7);
                int checkOptions = random.Next(0, 3);
                switch (checkOptions)
                {
                    case ladder:
                        if (position + diceOutcome <= 100)
                        {
                            position += diceOutcome;
                        }
                        break;
                    case snake:
                        if (position - diceOutcome < 0)
                        {
                            position = 0;
                        }
                        else
                        {
                            position -= diceOutcome;
                        }
                        break;
                    default:
                        break;
                }
                diceCount++;
                Console.WriteLine("curr postion of player is " + position);
            }
            if (position == win)
            {
                Console.WriteLine("Player win the game with the total dice roll count is " + diceCount);
            }
        }
    }
}