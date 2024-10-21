class Reference
{
    //attributes
    private string _book;

    private int _chapter;

    private int _startVerse;

    private int _endVerse;

    //methods
    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");
    }
}
