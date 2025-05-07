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
            int score = 0;
            Helpers helpers = new Helpers();
            var loop = Helpers.InitialiseGame();

            do
            {
                var (firstValue, secondValue, result) = Helpers.GetNumbersAndQuestion("-");

                helpers.GameLogic(result, firstValue, secondValue, ref score);

            } while (loop == false);
        }

        internal void multiplication()
        {
            int score = 0;
            Helpers helpers = new Helpers();
            var loop = Helpers.InitialiseGame();

            do
            {
                var (firstValue, secondValue, result) = Helpers.GetNumbersAndQuestion("x");

                helpers.GameLogic(result, firstValue, secondValue, ref score);

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
