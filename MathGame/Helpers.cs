using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Timers;
using System.Diagnostics;
using System.Threading;

namespace MathGame
{
    internal class Helpers
    {
        public static string player = GetName();
        public static List<Game> games = new List<Game>();
        public static Stopwatch timer = new Stopwatch();

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
                    Console.WriteLine($"Player Name: {player} || Game mode: {game.Type} || Score: {game.Score} || Time: {game.Time:mm\\:ss}");
                }
            }

            Console.WriteLine("press any key to exit");
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
                Console.WriteLine("i said state your name");
                player = Console.ReadLine();
            }
            return player;
        }

        internal static void AddToHistory(int score, GameType gameChoice, TimeSpan timeTaken)
        {
            games.Add(new Game
            {
                Type = gameChoice,
                Score = score,
                Time = timeTaken
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
                Console.WriteLine("decide yes or no");
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
            timer.Start();

            Console.Write("your answer: ");
            string input = Console.ReadLine();
            int userAnswer = Validation(input);
            return (firstValue, secondValue, userAnswer);
        }

        

        internal static bool InitialiseGame()
        {
            Console.Clear();
            timer.Reset();
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

        internal static void Randomise()
        {
            GameEngine engine = new GameEngine();

            Random test = new Random();
            int data = test.Next(3);

            switch (data)
            {
                case 0:
                    engine.PlayGame(GameType.Addition, "+", (a, b) => a + b);
                    break;
                case 1:
                    engine.PlayGame(GameType.Subtraction, "-", (a, b) => a - b);
                    break;
                case 2:
                    engine.PlayGame(GameType.Multiplication, "x", (a, b) => a * b);
                    break;
                case 3:
                    engine.PlayGame(GameType.Division, "/", (a, b) => a / b);
                    break;
            }
        }
        internal void GameLogic(int userAnswer, int expected, ref int score, GameType gameChoice)
        {
            GameEngine engine = new GameEngine();
            Menu menu = new Menu();

            if (userAnswer == expected)
            {
                Console.Clear();
                Console.WriteLine("correct");
                score++;
            }
            else
            {
                timer.Stop();
                TimeSpan timeTaken = timer.Elapsed;
                string elapsedTime = "time taken (mm:ss): " + timeTaken.ToString(@"mm\:ss");
                Console.WriteLine(elapsedTime);

                AddToHistory(score, gameChoice, timeTaken);
                Console.WriteLine($"incorrect. the correct answer was {expected}. your score is {score}.");
                string restartGame = ValidationYesOrNo("try again? y/n");

                if (restartGame == "y")
                {
                    Console.Clear();
                    timer.Reset();
                    if (gameChoice == GameType.Addition)
                    {
                        engine.PlayGame(GameType.Addition, "+", (a, b) => a + b);
                    }
                    else if (gameChoice == GameType.Subtraction)
                    {
                        engine.PlayGame(GameType.Subtraction, "-", (a, b) => a - b);
                    }
                    else if (gameChoice == GameType.Multiplication)
                    {
                        engine.PlayGame(GameType.Multiplication, "x", (a, b) => a * b);
                    }
                    else if (gameChoice == GameType.Division)
                    {
                        engine.PlayGame(GameType.Division, "/", (a, b) => a / b);
                    }
                    else if (gameChoice == GameType.Random)
                    {
                        engine.PlayGame(GameType.Random, "/", (a, b) => a / b);
                    }
                }
                else
                {
                    Console.Clear();
                    menu.GameMenu(player);
                }
            }
        }
    }
}
