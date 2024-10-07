using System;

public class Journal
{
    List<Entry> _entries = new List<Entry>;
    public Entry AddEntry()
    {

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

