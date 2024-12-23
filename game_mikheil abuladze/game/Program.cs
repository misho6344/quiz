using System;

class Program
{
    static void Main()
    {
        try
        {
            
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Player player = new Player(firstName, lastName);
            HangmanGame game = new HangmanGame(player);
            game.Play();

            
            Console.WriteLine("\nHighest Scorers:");
            GameStatistics.DisplayHighestScorers();
        }
        catch (Exception ex)
        {
            Logger.LogException(ex);
        }
    }
}
