using System;

class Program {

    static int GenerateRandNum(int upperBound) {
        Random rnd = new Random();
        int numberToGuess = rnd.Next(100);
        return numberToGuess;
    }

    static void Main(string[] args) {

        bool running = true;
        int numberToGuess = GenerateRandNum(100);
        int numberOfAttempts = 1;

        do {

        Console.Write("Please guess a number between 1 and 100 ");
        int userNumber = int.Parse(Console.ReadLine());

        if (userNumber == numberToGuess) {
            Console.WriteLine($"You guessed it! It took you {numberOfAttempts} times.");
            Console.Write("Would you like to play again? ");
            string playAgain = Console.ReadLine();
            if ( playAgain == "yes" ) {
                numberToGuess = GenerateRandNum(100);
                numberOfAttempts = 1;
            } else {
                running = false;
            }
        } else if ( userNumber > numberToGuess ) {
            Console.WriteLine("Guess lower");
            numberOfAttempts ++;
        } else if ( userNumber < numberToGuess ) {
            Console.WriteLine("Guess Higer");
            numberOfAttempts++;
        }
        } while (running);
    }
}
