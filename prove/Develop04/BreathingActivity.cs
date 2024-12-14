using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", 
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void StartBreathingExercise()
    {
        int elapsed = 0;
        int cycleTime = 5;
        int totalDuration = GetDuration();

        while (elapsed < totalDuration)
        {
            Console.Write("Breathe in...");
            Countdown(cycleTime);
            elapsed += cycleTime;
            if (elapsed >= totalDuration) break;

            Console.Write("Breathe out...");
            Countdown(cycleTime);
            elapsed += cycleTime;
        }
    }
}
