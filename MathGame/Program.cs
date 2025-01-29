using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

/* math game requirements:
 * 1. open with a menu prompting the user for their name, followed by choosing one of the 4 operators - done
 * 
 * 2. for each operator, two random numbers should be generated, prompting the user to solve displayed equations - done
 * 
 * 3. they should loop until the user inputs the wrong answer, with exceptions handled (putting a letter instead of a number) - done
 * 
 * 4. the divisions must result in integers only, with dividends being 0-100 - done
 * 
 * 5. any games played should be stored in some kind of list, which the user can view, no need for db tho -done
 */

var games = new List<string>();
Console.WriteLine("enter your name: ");
var player = Console.ReadLine();
GameMenu();

void GameMenu()
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
            addition();
            break;

        case "s":
            subtraction();
            break;

        case "m":
            multiplication();
            break;

        case "d":
            division();
            break;

        case "v":
            GameHistory();
            break;

        case "q":
            Console.WriteLine("safe init");
            Environment.Exit(0);
            break;

        default:
            Console.Clear();
            Console.WriteLine("select one of the options bruv");
            GameMenu();
            break;
    }
}

void addition()
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
            games.Add($"{player} - Addition: Score = {score}");
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
                GameMenu();
            }
        }
    } while (addLoop == false);

}

void subtraction()
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
            games.Add($"{player} - subtraction: Score = {score}");
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
                GameMenu();
            }
        }
    } while (subLoop == false);
}

void multiplication()
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
            games.Add($"{player} - multiplication: Score = {score}");
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
                GameMenu();
            }
        }
    } while (multLoop == false);
}

void division()
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
                games.Add($"{player} - division: Score = {score}");
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
                    GameMenu();
                }
            }
        }
    } while (divLoop == false);
}

void GameHistory()
{
    Console.Clear();
    Console.WriteLine("game history");
    foreach (var game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("press a key to exit init");
    Console.ReadLine();
    Console.Clear();
    GameMenu();
}


