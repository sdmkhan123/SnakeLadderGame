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

            //starting postion of both player
            int position1 = 0;
            int position2 = 0;

            // initialize both player
            bool playerOne = true;
            bool playerTwo = false;

            //iterate the loop till one of the player won the game
            while (position1 < win && position2 <win)
            {
                if (playerOne)
                {
                    Random random = new Random();
                    int diceOutcome = random.Next(1, 7);
                    int checkOptions = random.Next(0, 3);
                    switch (checkOptions)
                    {
                        case ladder:
                            if (position1 + diceOutcome <= 100)
                            {
                                position1 += diceOutcome;
                            }

                            // if player one get ladder the player1 pllay again
                            playerOne = true;
                            break;
                        case snake:
                            if (position1 - diceOutcome < 0)
                            {
                                position1 = 0;
                            }
                            else
                            {
                                position1 -= diceOutcome;
                            }
                            playerTwo = true;
                            playerOne = false;
                            break;
                        default:
                            playerTwo = true;
                            playerOne = false;
                            break;
                    };
                }
                else
                {
                    Random random = new Random();
                    int diceOutcome = random.Next(1, 7);
                    int checkOptions = random.Next(0, 3);
                    switch (checkOptions)
                    {
                        case ladder:
                            if (position2 + diceOutcome <= 100)
                            {
                                position2 += diceOutcome;
                            }

                            // id player one get ladder the player2 pllay again
                            playerTwo = true;
                            break;
                        case snake:
                            if (position2 - diceOutcome < 0)
                            {
                                position2 = 0;
                            }
                            else
                            {
                                position2 -= diceOutcome;
                            }
                            playerTwo = false;
                            playerOne = true;
                            break;
                        default:
                            playerTwo = false;
                            playerOne = true;
                            break;
                    };
                }
            }
            if (position1 > position2)
            {
                Console.WriteLine("PlayerOne won the game");
            }
            else
            {
                Console.WriteLine("PlayerTwo won the game");
            }
        }
    }
}