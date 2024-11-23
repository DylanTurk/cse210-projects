using System;
using System.IO;
using System.Threading.Tasks.Dataflow;

public class PromptGenerator
{
    List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    static string RandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,5);

        string selected = prompts[number];
        Console.WriteLine(selected);
        return selected;
    }
    
}