using System;
using System.Collections.Generic;
using MathGame;


namespace MathGame
{
    internal class Helpers
    {
        public static string player = GetName();
        public static List<string> games = new List<string>();
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
                    Console.WriteLine(game);
                }
            }
            
            Console.WriteLine("press a key to exit init");
            Console.ReadLine();
            Console.Clear();

            Menu menu = new Menu();
            menu.GameMenu(player);
        }

        internal static string GetName()
        {
            Console.WriteLine("enter your name: ");
            var player = Console.ReadLine();
            return player;
        }
    }
}
