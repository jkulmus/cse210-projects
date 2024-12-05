using System;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;
    public ListingActivity() : base("Listing", "This activity will help you recognize and list all the good things you have in certain areas of your life.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _count = 0;
    }
    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowCountDown(3);
        Console.WriteLine("Start listing items. . .");
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item)) _count++;
        }
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}