public class Reflcting : Activity
{
    //Attributes
    List<string> _mainPrompts;
    List<string> _subPrompts;

    //Methods
    public Reflcting()
    {
        _mainPrompts = [ "Think of a time when you stood up for someone else.",
                     "Think of a time when you did something really difficult.",
                     "Think of a time when you helped someone in need.",
                     "Think of a time when you did something truly selfless." ];
        _subPrompts = [ "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?" ];
    }

    private string GetRandPrompt(List<string>listOfPrompts)
    {
        Random rnd = new Random();
        var selection = rnd.Next(1, listOfPrompts.Count());
        return listOfPrompts[selection];
    }

    private int CalculateNumOfPrompts()
    {
        var num = _duration / 8;
        return num;
    }

    private void DispMainPrompt()
    {
        string prompt = GetRandPrompt(_mainPrompts);
        Console.WriteLine(prompt);
    }

    private void DispSubPrompts()
    {
        string prompt = GetRandPrompt(_subPrompts);
        Console.WriteLine(prompt);
    }

    public void ReflectingLoop()
    {
        StartActivity();
        DisplayAnimation(5);
        Console.Clear();
        GetDuration();
        Console.Clear();
        GetReady();
        DisplayAnimation(5);
        Console.Clear();
        var count = 0;
        var total = CalculateNumOfPrompts();
        DispMainPrompt();
        do
        {
            Console.WriteLine("");
            DispSubPrompts();
            Console.WriteLine();
            DisplayAnimation(8);
            count ++;
        } while (count < total);
    }
}
