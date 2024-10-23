class ReadWrite
{
    public string GetScripture(string filename, string reference)
    {
        string line;
        string cleanLine;
        string scripture = "";
        bool isScriptureLine = false;
        StreamReader sr = new StreamReader(filename);
        line = sr.ReadLine();
        cleanLine = line.Trim();
        if (line.StartsWith("REFERECE: "))
        {
            isScriptureLine = false;
        }

        if (line == $"REFERENCE: {reference}")
        {
            isScriptureLine = true;
        }

        if (isScriptureLine)
        {
            scripture += cleanLine.Replace("SCRIPTURE: ", "").Trim();
        }

        return scripture;

    }

    public void WriteScripture(string reference, string verse, string filename)
    {

    }

}
