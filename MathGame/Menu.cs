using System;
using MathGame;

namespace MathGame
{
    internal class Menu
    {
        GameEngine engine = new();

        public void GameMenu(string player)
        {
            Console.WriteLine("choose an operation to play in: ");
            Console.WriteLine("a - addition");
            Console.WriteLine("s - subtraction");
            Console.WriteLine("m - multiplication");
            Console.WriteLine("d - division");
            Console.WriteLine("v - view game history");
            Console.WriteLine("q - quit");
            var gameChoice = Console.ReadLine();

            switch (gameChoice.Trim().ToLower())
            {
                case "a":
                    engine.addition();
                    break;

                case "s":
                    engine.subtraction();
                    break;

                case "m":
                    engine.multiplication();
                    break;

                case "d":
                    engine.division();
                    break;

                case "v":
                    Helpers.GameHistory();
                    break;

                case "q":
                    Console.WriteLine("safe init");
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("select one of the options bruv");
                    GameMenu(player);
                    break;
            }
        }
    }
}
