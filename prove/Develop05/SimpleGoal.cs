using System;
using System.IO;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override int RecordProgress()
    {
        if (_isComplete == false)
        {
            MarkComplete();
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        string check;

        if (_isComplete == true)
        {
            check = "[X]";
        }
        else
        {
            check = "[ ]";
        }
        return check + $"{_name} ({_description})";
    }

    public override string SaveToData()
    {
        // Format: SimpleGoal|Name|Description|Points|IsComplete
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";
    }

    public override void LoadFromData(string data)
    {
        // Data format: SimpleGoal|Name|Description|Points|IsComplete
        var parts = data.Split('|');

        parts[0] = "SimpleGoal";
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _isComplete = bool.Parse(parts[4]);
    }
}
