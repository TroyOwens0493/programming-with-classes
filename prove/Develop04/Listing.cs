public class Listing : Activity
{

    //Attributes
    List<string> _prompts;
    int _numOfResponses;
    DateTime _startTime = new();
    DateTime _endTime = new();

    //Methods
    public Listing()
    {
        _prompts = [ "Who are people that you appreciate?",
                 "What are personal strengths of yours?",
                 "Who are people that you have helped this week?",
                 "When have you felt the Holy Ghost this month?",
                 "Who are some of your personal heroes?" ];
    }

    private string GetRandPrompt()
    {
        var rnd = new Random();
        return _prompts[rnd.Next(1, _prompts.Count())];
    }

    private void GetRes()
    {
        Console.Write(">");
        Console.ReadLine();
    }

    private void DispNumOfResponses(int num)
    {
        Console.WriteLine($"Congradulations! You asnwered with {num} answers!");
    }
    
    private void DispPrompt()
    {
        Console.WriteLine(GetRandPrompt());
    }

    public void ListingLoop()
    {
        StartActivity();
        DisplayAnimation(5);
        Console.Clear();
        GetDuration();
        Console.Clear();
        GetReady();
        DisplayAnimation(5);
        Console.Clear();
        DispPrompt();
        Console.WriteLine();
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);
        int numOfResponses = 0;
        do
        {
            GetRes();
            numOfResponses ++;
        } while (DateTime.Now < _endTime);
        DispNumOfResponses(numOfResponses);
    }
}
