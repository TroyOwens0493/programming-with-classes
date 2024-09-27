using System;

class Program {

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static int SquareNumber(int numberToSquare) {
        int numberSquared = (int)Math.Pow(numberToSquare, 2);
        return numberToSquare;
    }

    static void DisplayResult(string userName, int userNumberSquared) {
        Console.WriteLine($"{userName}, the square of your number is {userNumberSquared}");
    }

    static void Main(string[] args) {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userNumberSquared = SquareNumber(userNumber);
        DisplayResult(userName, userNumberSquared);
    }
}
