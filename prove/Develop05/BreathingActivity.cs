using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will walk you through breathing exercises to help you relax. CLear you mind and focus. Happy breathing!")
    {
    }
    public void Run()
    {
        Start();
        int duration = Duration;
        while (duration > 0)
        {
            Console.WriteLine("Breathe in. . .");
        }
        End();
    }
}