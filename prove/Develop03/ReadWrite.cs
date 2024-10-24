using System.Data;
// Troy and Bryson
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

        return scripture.Trim();

    }
    public void WriteScripture(string reference, string verse, string filename)
    {
        // ensures user enters a valid filename
        if (string.IsNullOrEmpty(filename))
        {
            throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));
        }

        //appends verse and reference onto existing file
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine($"\nREFERENCE: {reference}\n\nVERSE: {verse}");
        }
    }

}
