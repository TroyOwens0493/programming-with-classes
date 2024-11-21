public class ReadWrite
{
    public List<List<string>> ReadData(string filePath)
    {
        List<List<string>> allGoals = new();
        using (StreamReader sr = new StreamReader(filePath))
        {
            string line;
            bool isFirstLine = true;

            while ((line = sr.ReadLine()) != null)
            {
                // Add total points from the first line
                if (isFirstLine)
                {
                    allGoals.Add(new List<string> { line });
                    isFirstLine = false;
                }
                else
                {
                    // Add goal data
                    var goalData = line.Split(';').ToList();
                    allGoals.Add(goalData);
                }
            }
        }
        return allGoals;
    }

    public int ParsePointsFromData(List<List<string>> data)
    {
        if (data.Count == 0 || data[0].Count == 0)
        {
            throw new InvalidOperationException("Points data is missing or invalid.");
        }

        return int.Parse(data[0][0]);
    }

    public List<Goal> ParseDataAndMakeGoals(List<List<string>> data)
    {
        // Remove points entry
        data.RemoveAt(0);

        List<Goal> finishedGoalObjs = new();
        foreach (List<string> goal in data)
        {
            if (goal.Count < 4)
            {
                throw new FormatException("Goal data is incomplete or malformed.");
            }

            var goalType = goal[0];
            Console.WriteLine(goalType);
            var name = goal[1];
            var desc = goal[2];
            var pointVal = goal[3];

            if (goalType == "SimpleGoal")
            {
                if (goal.Count < 5) throw new FormatException("SimpleGoal data is incomplete.");
                var isComplete = goal[4];
                SimpleGoal newSimple = new SimpleGoal(name, desc, pointVal, isComplete);
                finishedGoalObjs.Add(newSimple);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal newEternal = new EternalGoal(name, desc, pointVal);
                finishedGoalObjs.Add(newEternal);
            }
            else if (goalType == "ChecklistGoal")
            {
                if (goal.Count < 7) throw new FormatException("ChecklistGoal data is incomplete.");
                var bonusPointVal = goal[4];
                var interval = goal[5];                
                var timesCompleted = goal[6];
                ChecklistGoal newChecklist = new ChecklistGoal(name, desc, pointVal, bonusPointVal, interval, timesCompleted);
                finishedGoalObjs.Add(newChecklist);
            }
            else
            {
                throw new InvalidOperationException($"Unknown goal type: {goalType}");
            }
        }
        return finishedGoalObjs;
    }

    public void WriteData(int points, List<Goal> goals, string fileName)
    {
        using (StreamWriter wr = new StreamWriter(fileName))
        {
            wr.WriteLine(points);
            foreach (Goal goal in goals)
            {
                var type = goal.GetType();
                var name = goal.GetGoalName();
                var desc = goal.GetGoalDesc();
                var pointVal = goal.GetPointValue();
                string goalData = "";
                if (type.ToString() == "SimpleGoal")
                {
                    var simpleGoal = goal as SimpleGoal;
                    var isComplete = simpleGoal.GetCompletionStatus();
                    goalData = $"SimpleGoal;{name};{desc};{pointVal};{isComplete}";
                }
                else if (type.ToString() == "EternalGoal")
                {
                    goalData = $"EternalGoal;{name};{desc};{pointVal}";
                }
                else
                {
                    var checklistGoal = goal as ChecklistGoal;
                    var bonusVal = checklistGoal.GetBonusPointVal().ToString();
                    var bonusInterval = checklistGoal.GetBonusInterval().ToString();
                    var timesCompleted = checklistGoal.GetTimesCompleted().ToString();
                    goalData = $"ChecklistGoal;{name};{desc};{pointVal};{bonusVal};{bonusInterval};{timesCompleted}";
                }
                wr.WriteLine(goalData);
            }
        }
    }
}
