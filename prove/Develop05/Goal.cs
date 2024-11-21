abstract public class Goal
{
    //Atr
    protected string _name;
    protected string _desc;
    protected int _pointVal;

    //Methods
    virtual public void Disp()
    {
        Console.WriteLine($"[ ] {_name} ({_desc})");
    }

    protected void SetGoalName()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
    }

    protected void SetGoalDesc()
    {
        Console.WriteLine("Please write a description for this goal: ");
        _desc = Console.ReadLine();
    }

    protected void SetPointValue()
    {
        Console.WriteLine("How many points do you want this goal to be worth? ");
        _pointVal = int.Parse(Console.ReadLine());
    }

    public string GetGoalName()
    {
        return _name;
    }

    public string GetGoalDesc()
    {
        return _desc;
    }

    public int GetPointValue()
    {
        return _pointVal;
    }

    virtual public void InitGoal()
    {
        SetGoalName();
        SetGoalDesc();
        SetPointValue();
    }

    abstract public int RecordEvent();
}
