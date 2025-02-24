using System;
using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        internal void addition()
        {
            int score = 0;
            Helpers helpers = new Helpers();
            var loop = Helpers.InitialiseGame();

            do
            {
                var (firstValue, secondValue, result) = Helpers.GetNumbersAndQuestion("+");

                helpers.GameLogic(result, firstValue, secondValue, ref score);
                
            } while (loop == false);
        }

        internal void subtraction()
        {
            Helpers helpers = new Helpers();
            var loop = Helpers.InitialiseGame();
            int score = 0;
            do
            {
                var (firstValue, secondValue, result) = Helpers.GetNumbersAndQuestion("-");


                if (result != firstValue - secondValue)
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
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("correct");
                    score++;
                }
                
            } while (loop == false);
        }

        internal void multiplication()
        {
            Helpers helpers = new Helpers();
            var loop = Helpers.InitialiseGame();
            do
            {
                var (firstValue, secondValue, result) = Helpers.GetNumbersAndQuestion("x");


                if (result != firstValue * secondValue)
                {
                    loop = true;
                    //Helpers.AddToHistory(score, GameType.Multiplication);
                    //Console.WriteLine($"finished cuz. you got {score}");
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
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("correct");
                   // score++;

                }
            } while (loop == false);
        }

        internal void division()
        {
            Helpers helpers = new Helpers();
            var loop = Helpers.InitialiseGame();
            do
            {
                var (firstValue, secondValue, result) = Helpers.CheckThatNumbersAreDivisable();

                if (result != firstValue / secondValue)
                {
                    loop = true;
                    //Helpers.AddToHistory(score, GameType.Division);
                    //Console.WriteLine($"finished cuz. you got {score}");
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
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("correct");
                    //score++;
                }

            } while (loop == false);
        }
    }
}
