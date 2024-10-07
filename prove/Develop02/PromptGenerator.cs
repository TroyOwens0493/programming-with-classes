using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        List<string> items = new
        { "potatos", "place holders go here"

        };
        Random random = new Random();
        int PromptIndex = random.Next(items.Count);
        string RandomPrompt = items[PromptIndex];
        Console.WriteLine($"your prompt:"+RandomPrompt )
    }
}

