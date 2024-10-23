using System.Data;

class ReadWrite
{
    public string GetScripture(string filename, string reference)
    {
        string scripture = "";
        bool isScriptureLine = false;
        using (StreamReader sr = new StreamReader(filename))
        {
            string line;
            string cleanLine;
            while ((line = sr.ReadLine()) != null)
            {
                //line = sr.ReadLine();
                cleanLine = line.Trim();
                if (cleanLine.StartsWith("REFERENCE: "))
                {
                    isScriptureLine = false;
                }

                if (cleanLine == $"REFERENCE: {reference}")
                {
                    isScriptureLine = true;
                }

                if (isScriptureLine)
                {
                    scripture += cleanLine.Replace("VERSE: ", "\n");
                }
            }
        }

        return scripture;

    }
    public void WriteScripture(string reference, List<Word> verse, string filename)
    {

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"REFERENCE: {reference}\n\nVERSE: ");
            foreach (Word word in verse)
            {
                outputFile.WriteLine($"{word} ");
            }
        }
    }
}
