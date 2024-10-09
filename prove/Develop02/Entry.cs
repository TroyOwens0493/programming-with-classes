// Work done by calvin and Bryson
public class Entry
{
    // attributes
    public DateTime _timestamp;

    public string _prompt;

    public string _body;

    // behaviors
    public string GetDateTime()
    {
        DateTime date = DateTime.Now;
        return date.ToString("MM/dd/yyyy");
    }

    public string GetPrompt()
    { 
        Prompts Prompts = new();
        _prompt = Prompts.NewPrompt();
        return _prompt;
    }

    public string GetResponse()
    {
        _body = Console.ReadLine();
        return _body;
    }

    public void Display()
    {
        Console.WriteLine($"Date - {_timestamp} - Prompt: {_prompt}\n {_body}");
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"{_prompt}: ");
    }
}
