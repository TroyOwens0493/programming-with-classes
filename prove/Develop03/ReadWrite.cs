using System.Data;

class ReadWrite
{
    public List<String> GetScripture(string filename, string reference)
    {
        string line;
        StreamReader sr = new StreamReader(filename);
        line = sr.ReadLine();


    }
    public void WriteScripture(string reference, List<Word> verse, string filename)
    {

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"REFERENCE: {reference}\n\n");
            foreach (Word word in verse)
            {
                outputFile.WriteLine($"VERSE: {word}\n\n");
            }
        }
    }
}