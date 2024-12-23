using System;
using System.Collections.Generic;
using System.IO;

public static class GameStatistics
{
    private static string statsFile = "game_stats.txt";

    public static void RecordGame(Player player)
    {
        try
        {
            File.AppendAllText(statsFile, $"{player.Name},{player.Surname},{player.Wins},{player.Losses},{player.TotalGamesPlayed}\n");
        }
        catch (Exception ex)
        {
            Logger.LogException(ex);
        }
    }

    public static void DisplayHighestScorers()
    {
        try
        {
            var lines = File.ReadAllLines(statsFile);
            var players = new Dictionary<string, Player>();

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                var name = parts[0];
                var surname = parts[1];
                var wins = int.Parse(parts[2]);
                var losses = int.Parse(parts[3]);
                var gamesPlayed = int.Parse(parts[4]);

                var playerKey = name + " " + surname;
                if (!players.ContainsKey(playerKey))
                {
                    players[playerKey] = new Player(name, surname);
                }

                var player = players[playerKey];
                player.AddWin(); 
            }

            foreach (var player in players.Values)
            {
                Console.WriteLine(player);
            }
        }
        catch (Exception ex)
        {
            Logger.LogException(ex);
        }
    }
}
