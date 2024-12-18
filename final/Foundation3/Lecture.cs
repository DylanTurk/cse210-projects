using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address,
                   string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n" +
               $"Event Type: Lecture\n" +
               $"Speaker: {_speaker}\n" +
               $"Capacity: {_capacity}";
    }

    protected override string GetEventType()
    {
        return "Lecture";
    }
}