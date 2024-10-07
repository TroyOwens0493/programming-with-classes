using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

class Program
{
    static string Main(string[] args)
    {
        List<string> items = new List<string>
        {"potatos", "place holders go here"};
        Random random = new Random();
        int PromptIndex = random.Next(items.Count);
        string RandomPrompt = items[PromptIndex];
        return RandomPrompt;
        
    }
}

