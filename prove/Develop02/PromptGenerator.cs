using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
// Work done by Calvin and Bryson
class GetPrompt
{
    public string NewPrompt()
    {
        List<string> items = new List<string>
        {"Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?","If I had one thing I could do over today?", 
        "what would it be?"};
        Random random = new Random();
        int PromptIndex = random.Next(items.Count);
        string RandomPrompt = items[PromptIndex];
        return RandomPrompt;
        
    }
}

