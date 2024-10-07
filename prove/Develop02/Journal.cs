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
            Entry.Display();
        }
    }
    public void LoadFile()
    {

    }
    public void SaveFile()
    {

    }

}

