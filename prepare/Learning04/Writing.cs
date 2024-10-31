public class Writing : Assignment
{
    //Attributes
    string _title;

    // Methods
    public Writing(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic}\n{_title}";
    }
}
