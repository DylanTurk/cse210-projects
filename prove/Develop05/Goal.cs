using System;
using System.IO;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    

    protected void MarkComplete()
    {
        _isComplete = true;
    }

    public abstract int RecordProgress();

    public abstract string GetStatus();

    public abstract string SaveToData();

    public abstract void LoadFromData(string data);
}
