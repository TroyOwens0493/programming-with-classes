public class ChecklistGoal : Goal
{
    //Attr
    private int _bonusPoints;
    private int _timesCompleted;
    private int _bonusInterval;

    //Methods
    public ChecklistGoal()
    {
    }

    public ChecklistGoal(string name, string desc, string pointVal, string bonusVal, string bonusInterval, string timesCompleted)
    {
        _name = name;
        _desc = desc;
        _pointVal = int.Parse(pointVal);
        _bonusPoints = int.Parse(bonusVal);
        _bonusInterval = int.Parse(bonusInterval);
        _timesCompleted = int.Parse(timesCompleted);
    }

    private void SetBonusInterval()
    {
        Console.WriteLine("How many times do you need to complete this goal for a bonus? ");
        _bonusInterval = int.Parse(Console.ReadLine());
    }

    private void SetBonusAmount()
    {
        Console.WriteLine("What is the bonus for completing the goal that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public int GetBonusInterval()
    {
        return _bonusInterval;
    }

    public int GetBonusPointVal()
    {
        return _bonusPoints;
    }

    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    override public void InitGoal()
    {
        SetGoalName();
        SetGoalDesc();
        SetPointValue();
        SetBonusInterval();
        SetBonusAmount();
    }

    override public void Disp()
    {
        // Inline if statement to see if the goal has been completed and display an x
        Console.WriteLine($"[{(_timesCompleted >= _bonusInterval ? "x" : " ")}] {_name} ({_desc}) -- Completed {_timesCompleted}/{_bonusInterval} times");
    }

    override public int RecordEvent()
    {
        // Only increase the number of times completed when the count is lower than the interval
        _timesCompleted += 1;

        if (_timesCompleted != _bonusInterval)
        {
            return _pointVal;
        }

        return _bonusPoints;
    }
}
