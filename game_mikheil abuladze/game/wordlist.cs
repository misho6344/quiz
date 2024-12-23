using System;
using System.Collections.Generic;
using System.IO;

public static class WordList
{
    private static List<string> words = new List<string>();

    static WordList()
    {
        
        try
        {
            words = new List<string>(File.ReadAllLines("words.txt"));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading words: " + ex.Message);
        }
    }

    public static string GetRandomWord()
    {
        Random rand = new Random();
        return words[rand.Next(words.Count)];
    }
}
