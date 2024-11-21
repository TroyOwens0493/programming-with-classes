public class EternalGoal : Goal
{
    //Methods
    public EternalGoal()
    {
    }

    public EternalGoal(string name, string desc, string pointVal)
    {
        _name = name;
        _desc = desc;
        _pointVal = int.Parse(pointVal);
    }

    override public int RecordEvent()
    {
        return _pointVal;
    }
}
