using System;
using System.IO;

public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _timesCompleted = 0;
    }

    public override int RecordProgress()
    {
        _timesCompleted++;
        return _points;
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
        return $"{check} {_name} ({_description}) - Completed {_timesCompleted} times";
    }

    public override string SaveToData()
    {
        // EternalGoal|Name|Description|Points|IsComplete|TimesCompleted
        return $"EternalGoal|{_name}|{_description}|{_points}|{_isComplete}|{_timesCompleted}";
    }

    public override void LoadFromData(string data)
    {
        // Format: EternalGoal|Name|Description|Points|IsComplete|TimesCompleted
        var parts = data.Split('|');

        parts[0] = "EternalGoal";
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _isComplete = bool.Parse(parts[4]);
        _timesCompleted = int.Parse(parts[5]);
    }
}
