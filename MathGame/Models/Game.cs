using MathGame;

namespace MathGame.Models;

public class Game
{
    public int Score { get; set; }
    public GameType Type { get; set; }
}

public enum GameType
{
    Addition, 
    Subtraction,
    Multiplication,
    Division
}