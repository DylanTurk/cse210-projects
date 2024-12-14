using System;
using System.Threading;

public class ListingActivity : Activity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void StartListing()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Length)];

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You have a few seconds to think about what you will list...");
        PauseWithSpinner(5);

        Console.WriteLine("Start listing items (press enter after each one). Keep going until time is up!");

        int count = 0;
        int totalDuration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(totalDuration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            if (Console.KeyAvailable)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item))
                {
                    count++;
                }
            }
            else
            {
                Thread.Sleep(250); 
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");
        PauseWithSpinner(3);
    }
}
