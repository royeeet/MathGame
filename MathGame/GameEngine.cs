using System;
using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        internal void addition()
        {

            var (loop, score) = Helpers.InitialiseGame();

            do
            {
                var (firstValue, secondValue, result) = Helpers.GetNumbersAndQuestion("+");

                
                if (result != firstValue + secondValue)
                {
                    loop = true;
                    Helpers.AddToHistory(score, GameType.Addition);
                    Console.WriteLine($"finished cuz. you got {score}");
                    string restartGame = Helpers.ValidationYesOrNo("try again y/n");

                    if (restartGame == "y")
                    {
                        Console.Clear();
                        addition();
                    }
                    else if (restartGame == "n")
                    {
                        Console.Clear();
                        Menu menu = new Menu();
                        menu.GameMenu(Helpers.player);
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("correct");
                    score++;
                }
            } while (loop == false);

        }

        internal void subtraction()
        {
            var (loop, score) = Helpers.InitialiseGame();
            do
            {
                var (firstValue, secondValue, result) = Helpers.GetNumbersAndQuestion("-");


                if (result == firstValue - secondValue)
                {
                    Console.Clear();
                    Console.WriteLine("correct");
                    score++;
                }
                else
                {
                    loop = true;
                    Helpers.AddToHistory(score, GameType.Subtraction);
                    Console.WriteLine($"finished cuz. you got {score}");
                    string restartGame = Helpers.ValidationYesOrNo("try again y/n");

                    if (restartGame == "y")
                    {
                        Console.Clear();
                        subtraction();
                    }
                    else if (restartGame == "n")
                    {
                        Console.Clear();
                        Menu menu = new Menu();
                        menu.GameMenu(Helpers.player);
                    }
                    else
                    {
                        Console.WriteLine("yes or no bruv");
                    }
                }
            } while (loop == false);
        }

        internal void multiplication()
        {
            var (loop, score) = Helpers.InitialiseGame();
            do
            {
                var (firstValue, secondValue, result) = Helpers.GetNumbersAndQuestion("x");


                if (result == firstValue * secondValue)
                {
                    Console.Clear();
                    Console.WriteLine("correct");
                    score++;
                }
                else
                {
                    loop = true;
                    Helpers.AddToHistory(score, GameType.Multiplication);
                    Console.WriteLine($"finished cuz. you got {score}");
                    string restartGame = Helpers.ValidationYesOrNo("try again y/n");

                    if (restartGame == "y")
                    {
                        Console.Clear();
                        multiplication();
                    }
                    else if (restartGame == "n")
                    {
                        Console.Clear();
                        Menu menu = new Menu();
                        menu.GameMenu(Helpers.player);
                    }
                    else
                    {
                        Console.WriteLine("yes or no bruv");
                    }
                }
            } while (loop == false);
        }

        internal void division()
        {
            var (loop, score) = Helpers.InitialiseGame();
            do
            {
                var (firstValue, secondValue, result) = Helpers.CheckThatNumbersAreDivisable();

                if (result == firstValue / secondValue)
                {
                    Console.Clear();
                    Console.WriteLine("correct");
                    score++;
                }
                else
                {
                    loop = true;
                    Helpers.AddToHistory(score, GameType.Division);
                    Console.WriteLine($"finished cuz. you got {score}");
                    string restartGame = Helpers.ValidationYesOrNo("try again y/n");

                    if (restartGame == "y")
                    {
                        Console.Clear();
                        division();
                    }
                    else if (restartGame == "n")
                    {
                        Console.Clear();
                        Menu menu = new Menu();
                        menu.GameMenu(Helpers.player);
                    }
                    else
                    {
                        Console.WriteLine("yes or no bruv");
                    }
                }

            } while (loop == false);
        }
    }
}
