using System;
using System.Globalization;

public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public DateTime Date
    {
        get { return _date; }
    }

    public int Length
    {
        get { return _length; }
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string activityType = this.GetType().Name;
        string dateStr = Date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
        double distance = Math.Round(GetDistance(), 2);
        double speed = Math.Round(GetSpeed(), 2);
        double pace = Math.Round(GetPace(), 2);

        return $"{dateStr} {activityType} ({Length} min): Distance {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
    }
}
