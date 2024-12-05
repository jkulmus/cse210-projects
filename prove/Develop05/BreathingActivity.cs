using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will walk you through breathing exercises to help you relax. CLear you mind and focus. Happy breathing!")
    {
    }
    public override void Run()
    {
        DisplayStartingMessage();
        int duration = Duration;
        while (duration > 0)
        {
            Console.WriteLine("Breathe in. . .");
            ShowCountDown(3);
            duration -=3;
            if (duration <= 0) break;
            Console.WriteLine("Breate out. . .");
            ShowCountDown(3);
            duration -= 3;
        }
        DisplayEndingMessage();
    }
}