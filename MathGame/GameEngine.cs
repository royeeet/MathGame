using System;
using System.Collections.Generic;
using MathGame;

namespace MathGame
{
    internal class GameEngine
    {
        internal void addition()
        {
            Console.Clear();
            var addLoop = false;
            var score = 0;

            do
            {
                Random rand = new Random();
                int add_firstValue = rand.Next(10);
                int add_secondValue = rand.Next(10);

                Console.WriteLine("solve the following: ");
                Console.WriteLine($"{add_firstValue} + {add_secondValue}");

                Console.Write("your answer: ");
                var addCheck = int.Parse(Console.ReadLine());
                if (addCheck == add_firstValue + add_secondValue)
                {
                    Console.Clear();
                    Console.WriteLine("correct");
                    score++;
                }
                else
                {
                    addLoop = true;
                    Helpers.games.Add($"{Helpers.player} - Addition: Score = {score}");
                    Console.WriteLine($"finished cuz. you got {score} try again? (y/n)");
                    var restartGame = Console.ReadLine();

                    if (restartGame == "y")
                    {
                        Console.Clear();
                        addition();
                    }
                    else
                    {
                        Console.Clear();
                        Menu menu = new Menu();
                        menu.GameMenu(Helpers.player);
                    }
                }
            } while (addLoop == false);

        }

        internal void subtraction()
        {
            Console.Clear();
            var subLoop = false;
            var score = 0;
            do
            {
                Random rand = new Random();
                int sub_firstValue = rand.Next(10);
                int sub_secondValue = rand.Next(10);

                Console.WriteLine("solve the following: ");
                Console.WriteLine($"{sub_firstValue} - {sub_secondValue}");

                Console.Write("your answer: ");
                var subCheck = int.Parse(Console.ReadLine());
                if (subCheck == sub_firstValue - sub_secondValue)
                {
                    Console.Clear();
                    Console.WriteLine("correct");
                    score++;
                }
                else
                {
                    subLoop = true;
                    Helpers.games.Add($"{Helpers.player} - subtraction: Score = {score}");
                    Console.WriteLine($"finished cuz. you got {score} try again? (y/n)");
                    var restartGame = Console.ReadLine();

                    if (restartGame == "y")
                    {
                        Console.Clear();
                        subtraction();
                    }
                    else
                    {
                        Console.Clear();
                        Menu menu = new Menu();
                        menu.GameMenu(Helpers.player);
                    }
                }
            } while (subLoop == false);
        }

        internal void multiplication()
        {
            Console.Clear();
            var multLoop = false;
            var score = 0;
            do
            {
                Random rand = new Random();
                int mult_firstValue = rand.Next(10);
                int mult_secondValue = rand.Next(10);

                Console.WriteLine("solve the following: ");
                Console.WriteLine($"{mult_firstValue} x {mult_secondValue}");

                Console.Write("your answer: ");
                var multCheck = int.Parse(Console.ReadLine());
                if (multCheck == mult_firstValue * mult_secondValue)
                {
                    Console.Clear();
                    Console.WriteLine("correct");
                    score++;
                }
                else
                {
                    multLoop = true;
                    Helpers.games.Add($"{Helpers.player} - multiplication: Score = {score}");
                    Console.WriteLine($"finished cuz. you got {score} try again? (y/n)");
                    var restartGame = Console.ReadLine();

                    if (restartGame == "y")
                    {
                        Console.Clear();
                        multiplication();
                    }
                    else
                    {
                        Console.Clear();
                        Menu menu = new Menu();
                        menu.GameMenu(Helpers.player);
                    }
                }
            } while (multLoop == false);
        }

        internal void division()
        {
            Console.Clear();
            var divLoop = false;
            var score = 0;
            do
            {
                Random rand = new Random();
                int div_firstValue = rand.Next(1, 100);
                int div_secondValue = rand.Next(1, 100);

                var remainderChecker = div_firstValue % div_secondValue;

                if (remainderChecker != 0)
                {
                    div_firstValue = rand.Next(1, 100);
                }

                else
                {
                    Console.WriteLine("solve the following: ");
                    Console.WriteLine($"{div_firstValue} / {div_secondValue}");

                    Console.Write("your answer: ");
                    var divCheck = int.Parse(Console.ReadLine());
                    if (divCheck == div_firstValue / div_secondValue)
                    {
                        Console.Clear();
                        Console.WriteLine("correct");
                        score++;
                    }
                    else
                    {
                        divLoop = true;
                        Helpers.games.Add($"{Helpers.player} - division: Score = {score}");
                        Console.WriteLine($"finished cuz. you got {score} try again? (y/n)");
                        var restartGame = Console.ReadLine();

                        if (restartGame == "y")
                        {
                            Console.Clear();
                            division();
                        }
                        else
                        {
                            Console.Clear();
                            Menu menu = new Menu();
                            menu.GameMenu(Helpers.player);
                        }
                    }
                }
            } while (divLoop == false);
        }
    }
}
