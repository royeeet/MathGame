﻿using System;

/* math game requirements:
 * 1. open with a menu prompting the user for their name, followed by choosing one of the 4 operators
 * 
 * 2. for each operator, two random numbers should be generated, prompting the user to solve displayed equations
 * 
 * 3. they should loop until the user inputs the wrong answer, with exceptions handled (putting a letter instead of a number)
 * 
 * 4. the divisions must result in integers only, with dividends being 0-100??(come back to that one)
 * 
 * 5. any games played should be stored in some kind of list, which the user can view, no need for db tho
 */

GameMenu();
void GameMenu()
{
    Console.WriteLine("enter your name: ");
    var player = Console.ReadLine();

    Console.WriteLine("choose an operation to play in: ");
    Console.WriteLine("a - addition");
    Console.WriteLine("s - subtraction");
    Console.WriteLine("m - multiplication");
    Console.WriteLine("d - division");
    var gameChoice = Console.ReadLine();

    switch (gameChoice)
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
        default:
            Console.WriteLine("select one of the options bruv");
            break;
    }
}

void addition()
{
    var addLoop = false;

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
            Console.WriteLine("correct");
        }
        else
        {
            addLoop = true;
        }
    } while (addLoop == false);
}

void subtraction()
{
    var subLoop = false;
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
            Console.WriteLine("correct");
        }
        else
        {
            subLoop = true;
        }
    } while (subLoop == false);
}


void multiplication()
{
    var multLoop = false;
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
            Console.WriteLine("correct");
        }
        else
        {
            multLoop = true;
        }
    } while (multLoop == false);
}

void division()
{
    var divLoop = false;
    do
    {
        Random rand = new Random();
        int div_firstValue = rand.Next(10);
        int div_secondValue = rand.Next(10);
        if (div_firstValue <=0 ||  div_secondValue <=0 || div_secondValue < div_firstValue)
        {
            rand.Next();
        }

        Console.WriteLine("solve the following: ");
        Console.WriteLine($"{div_firstValue} / {div_secondValue}");

        Console.Write("your answer: ");
        var divCheck = int.Parse(Console.ReadLine());
        if (divCheck == div_firstValue / div_secondValue)
        {
            Console.WriteLine("correct");
        }
        else
        {
            divLoop = true;
        }
    } while (divLoop == false);
}