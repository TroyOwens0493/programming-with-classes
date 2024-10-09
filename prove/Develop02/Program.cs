// using System;

class Program
{
        // Behaviors
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal program!");
        Console.WriteLine("Please choose what you would like to do.");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        string userSelection = Console.ReadLine();
        // Make a Journal obj
        Journal Journal = new();
        if ( userSelection == "1" ) {
            Journal.AddEntry();
        } else if ( userSelection == "2" ) {
            Journal.DisplayEntries();
        } else if ( userSelection == "3" ) {
            Journal.LoadFile();
        } else if ( userSelection == "4" ) {
            Journal.SaveFile();
        } else {
            Environment.Exit(0);
        }
    }
}
