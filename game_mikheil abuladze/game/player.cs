using System;

public class Player
{
    public string Name { get; }
    public string Surname { get; }
    public int TotalGamesPlayed { get; private set; }
    public int Wins { get; private set; }
    public int Losses { get; private set; }

    public Player(string name, string surname)
    {
        Name = name;
        Surname = surname;
        TotalGamesPlayed = 0;
        Wins = 0;
        Losses = 0;
    }

    public void AddWin()
    {
        Wins++;
        TotalGamesPlayed++;
    }

    public void AddLoss()
    {
        Losses++;
        TotalGamesPlayed++;
    }

    public override string ToString()
    {
        return $"{Name} {Surname}: Games Played = {TotalGamesPlayed}, Wins = {Wins}, Losses = {Losses}";
    }
}
