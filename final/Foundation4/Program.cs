using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Activity run = new Running(new DateTime(2022, 11, 3), 30, 3.0); // 3 miles in 30 minutes
        Activity cycle = new Cycling(new DateTime(2023, 1, 15), 45, 15.0); // 15 mph in 45 minutes
        Activity swim = new Swimming(new DateTime(2023, 5, 20), 60, 40); // 40 laps in 60 minutes

        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
