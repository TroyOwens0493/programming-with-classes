// Written by Troy
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
            foreach (Entry entry in _entries)
            {
                
                    outputFile.WriteLine($"Date - {entry._timestamp} - Prompt: {entry._prompt}\n {entry._body}");
            }
        }
    }
}

