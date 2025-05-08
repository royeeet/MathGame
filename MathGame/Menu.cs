using System;
using MathGame;
using MathGame.Models;

namespace MathGame
{
    internal class Menu
    {
        GameEngine gameMenu = new();

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
                    gameMenu.PlayGame(GameType.Addition, "+", (a, b) => a + b);
                    break;

                case "s":
                    gameMenu.PlayGame(GameType.Subtraction, "-", (a, b) => a - b);
                    break;

                case "m":
                    gameMenu.PlayGame(GameType.Multiplication, "*", (a, b) => a * b);
                    break;

                case "d":
                    gameMenu.PlayGame(GameType.Division, "/", (a, b) => a / b);
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
