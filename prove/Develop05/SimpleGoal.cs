public class SimpleGoal : Goal
{
    //Attr
    private bool _isFinished;

    //Methods
    public SimpleGoal()
    {
    }

    public SimpleGoal(string name, string desc, string pointVal, string isFinished)
    {
        _name = name;
        _desc = desc;
        _pointVal = int.Parse(pointVal);
        _isFinished = bool.Parse(isFinished);;
    }

    public bool GetCompletionStatus()
    {
        return _isFinished;
    }

    override public void Disp()
    {
        // Inline if statement to see if the goal has been completed and display an x
        Console.WriteLine($"[{(_isFinished ? "x" : " ")}] {_name} ({_desc})");
    }

    override public int RecordEvent()
    {
        _isFinished = true;
        return _pointVal;
    }
}
