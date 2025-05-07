using System;
using System.Collections.Generic;
using MathGame.Models;


namespace MathGame
{
    internal class Helpers
    {
        public static string player = GetName();
        public static List<Game> games = new List<Game>();

        public static void GameHistory()
        {
            Console.Clear();
            Console.WriteLine("game history");

            if (games == null || games.Count == 0)
            {
                Console.WriteLine("nothing to show");
            }
            else
            {
                foreach (var game in games)
                {
                    Console.WriteLine($"{player}: {game.Type} - Score = {game.Score}");
                }
            }

            Console.WriteLine("press a key to exit init");
            Console.ReadLine();
            Console.Clear();

            Menu menu = new Menu();
            menu.GameMenu(player);
        }

        internal static string GetName()
        {
            Console.WriteLine("enter your name: ");
            var player = Console.ReadLine();
            while (string.IsNullOrEmpty(player))
            {
                Console.WriteLine("i said state ur name cuz");
                player = Console.ReadLine();
            }
            return player;
        }

        internal static void AddToHistory(int score, GameType gameChoice)
        {
            games.Add(new Game
            {
                Type = gameChoice,
                Score = score
            });
        }

        internal static int Validation(string input)
        {
            int result;
            while (string.IsNullOrEmpty(input) || !Int32.TryParse(input, out result))
            {
                Console.WriteLine("answer needs to be an integer, try again");
                input = Console.ReadLine();
            }
            return result;
        }

        internal static string ValidationYesOrNo(string prompt)
        {
            Console.WriteLine(prompt);
            string yesOrNo = Console.ReadLine();
            while (yesOrNo != "y" && yesOrNo != "n")
            {
                Console.WriteLine("yes or no bruv");
                yesOrNo = Console.ReadLine();
            }
            return yesOrNo;
        }

        internal static (int, int, int) GetNumbersAndQuestion(string operation)
        {
            Random rand = new Random();
            int firstValue = rand.Next(10);
            int secondValue = rand.Next(10);

            Console.WriteLine("solve the following: ");
            Console.WriteLine($"{firstValue} {operation} {secondValue}");

            Console.Write("your answer: ");
            string input = Console.ReadLine();
            int userAnswer = Validation(input);
            return (firstValue, secondValue, userAnswer);
        }

        internal static bool InitialiseGame()
        {
            Console.Clear();
            bool loop = false;
            return loop;
        }

        internal static (int, int, int) CheckThatNumbersAreDivisable()
        {
            Random rand = new Random();
            int dividend, divisor;

            do
            {
                dividend = rand.Next(1, 100);
                divisor = rand.Next(1, 100);
            }
            while (dividend % divisor != 0);

            Console.WriteLine("solve the following: ");
            Console.WriteLine($"{dividend} / {divisor}");
            string input = Console.ReadLine();
            int userAnswer = Validation(input);

            return (dividend, divisor, userAnswer);
        }

        internal void GameLogic(int result, int firstValue, int secondValue, ref int score, GameType gameChoice)
        {
            GameEngine engine = new GameEngine();
            if (result != firstValue + secondValue)
            {
                AddToHistory(score, gameChoice);
                Console.WriteLine($"finished cuz. you got {score}");
                string restartGame = ValidationYesOrNo("try again y/n");

                if (restartGame == "y")
                {
                    Console.Clear();
                    if (gameChoice == GameType.Addition)
                    {
                        engine.addition();
                    }
                    else if (gameChoice == GameType.Subtraction)
                    {
                        engine.subtraction();
                    }
                    else if (gameChoice == GameType.Multiplication)
                    {
                        engine.multiplication();
                    }
                    else if (gameChoice == GameType.Division)
                    {
                        engine.division();
                    }   

                }
                else if (restartGame == "n")
                {
                    Console.Clear();
                    Menu menu = new Menu();
                    menu.GameMenu(player);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("correct");
                score++;
            }
        }

    }
}
