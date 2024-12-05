using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on your life. You are strong, powerful, and resilient.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);
        int duration = Duration;
        while (duration > 0)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
            duration -=5;
        }
        DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
    private string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }
}