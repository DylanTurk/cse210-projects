public class Swimming : Activity
{
    private int _laps;
    private const double _metersPerLap = 50;
    private const double _kmPerMeter = 0.001;
    private const double _milesPerKm = 0.62;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distanceKm = _laps * _metersPerLap * _kmPerMeter;
        double distanceMiles = distanceKm * _milesPerKm;
        return distanceMiles;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Length) * 60;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        if (distance == 0) return 0;
        return (double)Length / distance;
    }
}
