using System;
using System.Diagnostics;
using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {

        internal void PlayGame(GameType gameType, string symbol, Func<int, int, int> operation)
        {
            int score = 0;
            Helpers helpers = new Helpers();
            var loop = Helpers.InitialiseGame();

            do
            {
                var (firstValue, secondValue, userAnswer) = gameType switch
                {
                    GameType.Division => Helpers.CheckThatNumbersAreDivisable(),

                    GameType.Random => Helpers.Randomise(),

                    GameType.Addition or GameType.Subtraction or GameType.Multiplication => Helpers.GetNumbersAndQuestion(symbol)

                }; // == GameType.Division ? Helpers.CheckThatNumbersAreDivisable() : Helpers.GetNumbersAndQuestion(symbol); 
                
                int expected = operation(firstValue, secondValue);

                helpers.GameLogic(userAnswer, expected, ref score, gameType);

                
            } while (!loop);
        }

    }
}
