// Work done by calvin and Bryson
public class Entry
{
    // attributes
    public DateTime _timestamp;

    public string _prompt;

    public string _body;

    // behaviors
    public DateTime GetDateTime()
    {
        _timestamp = DateTime.Now;
        _timestamp.ToString("MM/dd/yyyy");
        return _timestamp;
    }

    public string GetPrompt()
    {
        _prompt = ();
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
}
