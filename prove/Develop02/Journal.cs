using System;

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
        Console.Write("What is the filename?");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry newEntry = new Entry();
        
            newEntry._timestamp = parts[0];
            newEntry._prompt = parts[1];
            newEntry._body = parts[2];

            _entries.Add(newEntry);
        }
    }
    public void SaveFile()
    {

    }

}

