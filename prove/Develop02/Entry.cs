public class Entry
{
    // attributes
    public DateTime _timestamp;

    public string _prompt;

    public string _body;

    // behaviors
    public DateTime GetDateTime()
    {
        return DateTime.Now;
    }

    public string GetPrompt()
    {
        ;
    }

    public string GetResponse()
    {
        return Console.ReadLine();
    }

    public void Display()
}
