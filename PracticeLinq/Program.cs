using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var videoGamesList = new List<string>()
            {
                "Super Mario Bros",
                "Dark Souls",
                "Crash Bandicoot",
                "Red Dead Redemption 2",
                "Metal Gear Solid",
                "Zork"
            };

            var orderedGames = videoGamesList.OrderBy(game => game.Length).ToList();

            //foreach(var game in orderedGames)
            //{
            //    Console.WriteLine(game);
            //}

            orderedGames.ForEach(game => Console.WriteLine(game));
        }
    }
}
