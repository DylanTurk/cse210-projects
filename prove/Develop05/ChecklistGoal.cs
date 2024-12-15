using System;
using System.IO;

public class ChecklistGoal : Goal
{
    private int _currentCount;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
        : base(name, description, points)
    {
        _currentCount = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordProgress()
    {
        if (_isComplete == false)
        {
            _currentCount++;
            int earned = _points;
            if (_currentCount == _targetCount)
            {
                MarkComplete();
                earned += _bonusPoints;
            }
            return earned;
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
        return $"{check} {_name} ({_description}) - Completed {_currentCount}/{_targetCount} times";
    }

    public override string SaveToData()
    {
        // ChecklistGoal|Name|Description|Points|IsComplete|CurrentCount|TargetCount|BonusPoints
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_isComplete}|{_currentCount}|{_targetCount}|{_bonusPoints}";
    }

    public override void LoadFromData(string data)
    {
        // Format: ChecklistGoal|Name|Description|Points|IsComplete|CurrentCount|TargetCount|BonusPoints
        var parts = data.Split('|');

        parts[0] = "ChecklistGoal";
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _isComplete = bool.Parse(parts[4]);
        _currentCount = int.Parse(parts[5]);
        _targetCount = int.Parse(parts[6]);
        _bonusPoints = int.Parse(parts[7]);
    }
}
