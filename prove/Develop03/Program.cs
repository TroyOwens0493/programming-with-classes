using System;

class Program
{
    static void Main(string[] args)
    {

        Scripture myScripture = new();
        Reference myReference = new();
        ReadWrite readwrite = new();
        Console.WriteLine(readwrite.GetScripture("scripture.txt", "Helaman 5"));
        bool exit = false;

        myReference.Display();
        myScripture.Display();
        do
        {
            Console.WriteLine("Welcome to the scrpture memorizer program.\n 1. Memorize a verse\n 2. Add a new verse\n 3. Load a scripture from a file\n 4. Exit");
            string action = Console.ReadLine();
            if (action == "1")
            {
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
            else if (action == "2")
            {
                Console.WriteLine("Please type in the scripture refernce:");
                string refernce = Console.ReadLine();
                Console.WriteLine("Please paste in the scripture verses:");
                string verses = Console.ReadLine();
                Console.WriteLine("Please type the name of the file you would like to add this too:");
                string fileName = Console.ReadLine();
                readwrite.WriteScripture(refernce, verses, fileName);
            }
            else if (action == "3")
            {
                Console.WriteLine("Please type the file name");
                string fileName = Console.ReadLine();
                Console.WriteLine("Please type the verse reference");
                string reference = Console.ReadLine();
            }
            else if (action == "4")
            {
                exit = true;
            }
        } while (!exit);
    }
}
