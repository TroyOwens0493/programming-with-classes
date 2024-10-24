using System;

class Program
{
    static void Main(string[] args)
    {

        ReadWrite readwrite = new();
        Console.WriteLine(readwrite.GetScripture("scripture.txt", "Helaman 5"));
        bool exit = false;

        // Get the scripture from a file
        Console.WriteLine("Please type the file name");
        string fileName = Console.ReadLine();
        Console.WriteLine("Please type the verse reference");
        string reference = Console.ReadLine();
        readwrite.GetScripture(fileName, reference);
        Reference myReference = new Reference(reference);
        Scripture myScripture = new Scripture(scripture);

        //Main menu
        myReference.Display();
        myScripture.Display();
        do
        {
            Console.WriteLine("Welcome to the scrpture memorizer program.\n 1. Memorize a verse\n 2. Add a new verse\n 3. Exit");
            string action = Console.ReadLine();
            if (action == "1")
            {
                do//Repeat this until the user chooses to exit
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
            else if (action == "2")
            {
                Console.WriteLine("Please type in the scripture refernce:");
                string refernce = Console.ReadLine();
                Console.WriteLine("Please paste in the scripture verses:");
                string verses = Console.ReadLine();
                Console.WriteLine("Please type the name of the file you would like to add this too:");
                string newFileName = Console.ReadLine();
                readwrite.WriteScripture(refernce, verses, newFileName);
            }
            else if (action == "3")
            {
                exit = true;
            }
        } while (!exit);
    }
}
