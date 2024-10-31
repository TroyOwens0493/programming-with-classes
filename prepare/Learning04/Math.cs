public class Math : Assignment
{
    //Attributes
    private string _textbookSection;
    private string _problems;

    //Methods
    public Math(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic}\n{_textbookSection} {_problems}";
    }
}
