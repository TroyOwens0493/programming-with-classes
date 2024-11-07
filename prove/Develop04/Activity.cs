public class Activity
{

    //Attributes
    protected int _duration = new();
    public DateTime _systemTime = new();
    protected string _activity;
    protected string _activityDesc;

    //Methods

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"You have chosen the {_activity} activity, in this activity you will: {_activityDesc}");
    }

    public void GetDuration()
    {
        Console.WriteLine("How long would you like this activity to last (in seconds): ");
        var res = Console.ReadLine();
        _duration = int.Parse(res);
    }

    public void GetReady()
    {
        Console.WriteLine($"Ok! this activity will last for {_duration} seconds!");
    }

    public void EndActivity()
    {
        Console.WriteLine($"You have completed the {_activity} activity for {_duration} seconds!");
    }

    public void DisplayAnimation(int seconds)
    {
        // Convert seconds to milliseconds for Thread.Sleep
        var sleepTime = (seconds * 1000) / 10; // Sleep time per interval in milliseconds
        double totalTime = 0.0;
        const int totalIntervals = 10; // We want to replace 10 dots with hashtags

        Console.Write(" . . . . . . . . . . ");
        Console.SetCursorPosition(Console.CursorLeft - 20, Console.CursorTop);

        for (int i = 0; i < totalIntervals; i++)
        {
            Console.Write(" #");
            Thread.Sleep(sleepTime);
            totalTime += sleepTime / 1000.0; // Convert back to seconds for comparison
        }
    }
}
