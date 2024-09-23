using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string askPercent = Console.ReadLine();

        int percent = int.Parse(askPercent);
        string letterGrade= "A";

        if (percent >= 90)
        {
            letterGrade = "A";
        }
        else if (percent >= 80)
        {
            letterGrade = "B";
        }
        else if (percent >= 70)
        {
            letterGrade = "C";
        }
        else if (percent >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You failed, better luck next time.");
        }
    }
}