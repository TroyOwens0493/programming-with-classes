using System;

class Program
{
    static void Main(string[] args)
    {
        var goals = new List<Goal>();
        var readerWriter = new ReadWrite();
        var points = 0;
        string fileName = "";
        // Main loop for program
        do
        {
            int res = MainMenu(points);
            if (res == 1)
            {
                int sel = MakeGoalMenu();
                if (sel == 1)
                {
                    var newSimple = new SimpleGoal();
                    newSimple.InitGoal();
                    goals.Add(newSimple);
                }
                else if (sel == 2)
                {
                    var newEternal = new EternalGoal();
                    newEternal.InitGoal();
                    goals.Add(newEternal);
                }
                else if (sel == 3)
                {
                    var newChecklist = new ChecklistGoal();
                    newChecklist.InitGoal();
                    goals.Add(newChecklist);
                }
            }
            else if (res == 2)
            {
                ListGoals(goals);
                Console.WriteLine("Press anything to continue");
                Console.ReadLine();
            }
            else if (res == 3)
            {
                Console.Clear();
                Console.Write("Please enter the name of the file you want to save to. (Must end in .txt) ");
                fileName = Console.ReadLine();
                readerWriter.WriteData(points, goals, fileName);
            }
            else if (res == 4)
            {
                Console.Clear();
                Console.Write("What is the name of the file that you want to read from? ");
                fileName = Console.ReadLine();
                var data = readerWriter.ReadData(fileName);
                points = readerWriter.ParsePointsFromData(data);
                var savedGoals = readerWriter.ParseDataAndMakeGoals(data);
                foreach (Goal savedGoal in savedGoals)
                {
                    goals.Add(savedGoal);
                }
            }
            else if (res == 5)
            {
                Console.Clear();
                ListGoals(goals);
                Console.Write("Which goal would you like to record and event on? ");
                var sel = int.Parse(Console.ReadLine());
                points += goals[sel - 1].RecordEvent();
            }
            else
            {
                if (fileName != "")
                {
                    readerWriter.WriteData(points, goals, fileName);
                    Environment.Exit(0);
                }
            }
        } while (true);
    }

    static int MainMenu(int points)
    {
        Console.Clear();
        Console.WriteLine($"You have {points} points");
        Console.WriteLine("Menu options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit(Program will autosave to the loaded file)\nSelect a choice from the menu: ");
        string res = Console.ReadLine();
        return int.Parse(res);
    }

    static int MakeGoalMenu()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich type of goal would you like to create? (Enter to go back) ");
        string str = Console.ReadLine();
        int res = 0;
        // If the user doesn't type a number, return 0
        int.TryParse(str, out res);
        return res;
    }

    static void RecordEventMenu(List<Goal> goals)
    {
        Console.Clear();
        ListGoals(goals);
        Console.WriteLine("Which goal would you like to record an event for? (Press enter to go back)");
        int res = 0;
        // If the user doesn't type a number, return 0
        int.TryParse(Console.ReadLine(), out res);
        goals[res - 1].RecordEvent();
    }

    static void ListGoals(List<Goal> Goals)
    {
        Console.Clear();
        Console.WriteLine("The goals are:");
        Console.WriteLine();
        for (int i = 0; i < Goals.Count(); i++)
        {
            Goal currentGoal = Goals[i];
            Console.Write($"{i + 1}. ");
            Goals[i].Disp();
        }
    }
}
