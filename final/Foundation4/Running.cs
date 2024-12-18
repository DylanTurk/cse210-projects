public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / Length) * 60;
    }

    public override double GetPace()
    {
        if (_distance == 0) return 0;
        return (double)Length / _distance;
    }
}
