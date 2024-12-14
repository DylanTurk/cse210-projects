using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration; // in seconds

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Run()
    {
        ShowStartingMessage();
        PrepareToBegin();
    }


    protected void ShowStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine() ?? "30");
        Console.WriteLine("Great! Prepare to begin...");
        PauseWithSpinner(5);
    }

    public void ShowFinishingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        PauseWithSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        PauseWithSpinner(5);
    }

    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "... ");
            Thread.Sleep(1000);
            Console.Write("\b\b\b    \b\b\b");
        }
        Console.WriteLine();
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("Get ready...");
        PauseWithSpinner(3);
        Console.Clear();
    }

    public int GetDuration()
    {
        return _duration;
    }
}
