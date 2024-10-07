namespace Sandbox2;

class Program
{

    static string ReturnAWord() {
        List<string> wordBank = ["daper", "coffee", "fire", "hangman", "csharp", "spikeball", "nature", "weather", "blanket", "states", "world", "missionaries"];
        Random rnd = new();
        int randomWordIndex = rnd.Next(wordBank.Count());
        string wordToReturn = wordBank[randomWordIndex];
        return wordToReturn;
    }

    static string GetProgressOnWord(string wordToGuess, List<char> correctLetters) {
        string progress = "_" * wordToGuess.Count();
        foreach (char letter in correctLetters) {
            if (wordToGuess.Contains(letter)) {
                progress = progress.Substring(0, progress.IndexOf(letter) - 1) + letter + progress.Substring(progress.IndexOf(letter));
            }
        }
    }

    static void PrintGameStatus(string progress, List<char> incorrectLetters, int numberOfGuesses) {
        Console.WriteLine($"Incorrect guesses: {incorrectLetters}");
        Console.WriteLine($"Progress: {progress}");
        Console.WriteLine($"Number of Guesses: {numberOfGuesses}");
    }

    static char GetUserGuess() {
        Console.Write("Please enter a letter as your guess.");
        char userGuess = char.Parse(Console.ReadLine());
        return userGuess;
    }

    static void Main(string[] args) {
        Console.WriteLine("Welcome to hangman. I chose a random word and you need to guess what it is. Each time you choose a letter, you will be told if you are right or not and then you will get to go agiain until you either win or lose.");
        Console.Write("How many attemps to you want?");
        int numberOfGuessesUntillEnd = int.Parse(Console.Read());
    }
}
