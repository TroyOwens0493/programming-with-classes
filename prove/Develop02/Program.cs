using System;

class Program
{
    // Attributes
    string userSelection;

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
        if ( userSelection = "1" ) {
            string promptForUser = Entry.GetPrompt();
            DateTime timeOfEntry = Entry.GetDateTime();
            string userJournalEntry = Console.ReadLine();
            string formattedEntry = formatJournalEntry(timeOfEntry, promptForUser, userJournalEntry);
            Journal.AddEntries(formattedEntry);
    }

    static string formatJournalEntry(DateTime time_of_entry, string promptForUser, string journalEntry) {
        DateTime.Parse(time_of_entry);
    }
}
