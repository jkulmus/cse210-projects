using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {_name} Activity");
    }

    public void End()
    {
        Console.WriteLine("Yay! You did it!!!");
        Console.WriteLine("$You have completed the {_name} activity for {_duration} seconds");
    }

    public void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public int Duration => _duration;
    public void 
}