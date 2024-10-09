using System;
using System.IO;

public class Journal
{
    List<Entry> _entries = new List<Entry>();
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        
        newEntry._timestamp = newEntry.GetDateTime();
        newEntry._prompt = newEntry.GetPrompt();
        newEntry._body = newEntry.GetResponse();

        _entries.Add(newEntry);
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void LoadFile()
    {

    }
    public void SaveFile()
    {
        Console.Write("What do you want to name the file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("Datetime,Prompt,Response");
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._timestamp}|{entry._prompt}|{entry._body}");
            }
        }
    }
}

