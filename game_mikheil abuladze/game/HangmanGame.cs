using System;
using System.Linq;

public class HangmanGame
{
    private string secretWord;
    private string displayedWord;
    private string incorrectGuesses;
    private int incorrectAttemptsLeft;
    private Player player;

    private const int MaxIncorrectGuesses = 6; 

    public HangmanGame(Player player)
    {
        this.player = player;
        incorrectGuesses = string.Empty;
        incorrectAttemptsLeft = MaxIncorrectGuesses;
        secretWord = WordList.GetRandomWord();
        displayedWord = new string('_', secretWord.Length);
    }

    public void Play()
    {
        Console.WriteLine("Welcome to Hangman, " + player.Name);
        Console.WriteLine("The word to guess: " + displayedWord);
        while (incorrectAttemptsLeft > 0 && displayedWord.Contains("_"))
        {
            Console.WriteLine($"Incorrect guesses: {incorrectGuesses}");
            Console.WriteLine($"You have {incorrectAttemptsLeft} incorrect attempts left.");
            Console.WriteLine("Guess a letter:");

            char guessedLetter = Console.ReadLine()[0];

            if (incorrectGuesses.Contains(guessedLetter) || displayedWord.Contains(guessedLetter.ToString()))
            {
                Console.WriteLine("You've already guessed that letter. Try again.");
                continue;
            }

            if (secretWord.Contains(guessedLetter))
            {
                UpdateDisplayedWord(guessedLetter);
                Console.WriteLine($"Good guess! The word now looks like: {displayedWord}");
            }
            else
            {
                incorrectGuesses += guessedLetter;
                incorrectAttemptsLeft--;
                Console.WriteLine($"Wrong guess. You have {incorrectAttemptsLeft} attempts left.");
            }
        }

        EndGame();
    }

    private void UpdateDisplayedWord(char letter)
    {
        char[] wordArray = displayedWord.ToCharArray();
        for (int i = 0; i < secretWord.Length; i++)
        {
            if (secretWord[i] == letter)
            {
                wordArray[i] = letter;
            }
        }
        displayedWord = new string(wordArray);
    }

    private void EndGame()
    {
        if (displayedWord.Equals(secretWord))
        {
            Console.WriteLine("Congratulations! You've guessed the word: " + secretWord);
            player.AddWin();
        }
        else
        {
            Console.WriteLine($"You've lost. The word was: {secretWord}");
            player.AddLoss();
        }

        GameStatistics.RecordGame(player);
    }
}
