using MathGame;
using System;

namespace MathGame.Models;

public class Game
{
    public int Score { get; set; }
    public GameType Type { get; set; }
    public TimeSpan Time { get; set; }
}

public enum GameType
{
    Addition, 
    Subtraction,
    Multiplication,
    Division,
    Random
}