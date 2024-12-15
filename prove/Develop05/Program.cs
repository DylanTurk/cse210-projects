using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;
        string filename;

        while (running)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Total Score: {manager.TotalScore}");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record event (complete or progress a goal)");
            Console.WriteLine("3. List goals");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal(manager);
            }
            else if (choice == "2")
            {
                RecordGoalEvent(manager);
            }
            else if (choice == "3")
            {
                manager.DisplayGoals();
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the file name? ");
                filename = Console.ReadLine();
                manager.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("What is the file name? ");
                filename = Console.ReadLine();
                manager.LoadFromFile(filename);
            }
            else if (choice == "6")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        Console.WriteLine("Goodbye!");
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("\nChoose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string desc = Console.ReadLine();

        Console.Write("Enter points awarded: ");
        int points = int.Parse(Console.ReadLine());

        Goal g = null;

        if (typeChoice == "1") 
        {
            g = new SimpleGoal(name, desc, points);
        }
        else if (typeChoice == "2") 
        {
            g = new EternalGoal(name, desc, points);
        }
        else if (typeChoice == "3") 
        {
            Console.Write("Enter target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            g = new ChecklistGoal(name, desc, points, targetCount, bonusPoints);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        manager.AddGoal(g);
        Console.WriteLine("Goal added successfully.");
    }

    static void RecordGoalEvent(GoalManager manager)
    {
        if (manager.GetGoalCount() == 0)
        {
            Console.WriteLine("No goals to record progress on.");
            return;
        }

        manager.DisplayGoals();
        Console.Write("Enter the number of the goal you want to record progress for: ");
        if (int.TryParse(Console.ReadLine(), out int idx))
        {
            manager.RecordGoalProgress(idx - 1);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}