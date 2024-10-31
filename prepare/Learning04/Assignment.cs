public class Assignment
{
    //Attributes
    protected string _studentName;
    protected string _topic;

    //Methods
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
