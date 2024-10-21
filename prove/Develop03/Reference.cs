class Reference
{
    //attributes
    private string _book;

    private int _chapter;

    private int _startVerse;

    private int _endVerse;

    //methods
    public void setBook(string book)
    {
        _book = book;
    }

    public void setChapter(int chapter)
    {
        _chapter = chapter;
    }

    public void setStartVerse(int startVerse)
    {
        _startVerse = startVerse;
    }

    public void setEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");
    }
}
