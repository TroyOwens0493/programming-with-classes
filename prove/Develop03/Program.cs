using System;

class Program
{
    static void Main(string[] args)
    {

        Scripture myScripture = new();
        bool exit = false;

        myScripture.Display();

        do
        {
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string userInput = Console.ReadLine();
        if (userInput == "")
        {
            myScripture.HideWords(3);
            myScripture.Display();
        }

        else if (userInput == "quit")
        {
            exit = true;
        }
        } while (!exit);

    }
}
