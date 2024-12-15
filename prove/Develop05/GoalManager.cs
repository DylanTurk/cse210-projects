using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalScore = 0;

    public int TotalScore => _totalScore;


    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetStatus()}");
        }
    }

    public void RecordGoalProgress(int index)
    {
        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        int pointsEarned = _goals[index].RecordProgress();
        _totalScore += pointsEarned;
        Console.WriteLine($"Recorded progress. You earned {pointsEarned} points!");
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalScore);

            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.SaveToData());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved file found.");
            return;
        }

        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string scoreLine = reader.ReadLine();
            _totalScore = int.Parse(scoreLine);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                var goalType = parts[0];
                Goal g = null;

                switch (goalType)
                {
                    case "SimpleGoal":
                        g = new SimpleGoal("temp","temp",0);
                        break;
                    case "EternalGoal":
                        g = new EternalGoal("temp","temp",0);
                        break;
                    case "ChecklistGoal":
                        g = new ChecklistGoal("temp","temp",0,0,0);
                        break;
                }

                g.LoadFromData(line);
                _goals.Add(g);
            }
        }
        Console.WriteLine("Goals loaded.");
    }

    public int GetGoalCount()
    {
        return _goals.Count;
    }
}
