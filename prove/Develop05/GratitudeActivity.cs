using System;
public class GratitudeActivity : Activity
{
    private List<string> _prompts;
    private List<string> _gratitudeList; // list of the items your grateful for

    public GratitudeActivity() : base("Gratitude", "This activity will help you focus on the things to be grateful in your life.")
    {
        _prompts = new List<string>
        {
            "What are you grateful for today?",
            "Who in your life are you grateful for?",
            "What recent life event are you thankful for?",
            "What is something you appreciate about yourself?",
            "What is a positive experience you have had recently?"
        };
        _gratitudeList = new List<string>(); // initialize the list
    }
    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowCountDown(3);
        Console.WriteLine("List things you are grateful for. . .");
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        // The things the user is grateful for
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                _gratitudeList.Add(item); // Add gratitude items to the list
            }
        }

        // Display how many items and what the user listed
        Console.WriteLine($"You listed {_gratitudeList.Count} things you are grateful for.");
        Console.WriteLine("Here are the things you are grateful for:");

        foreach (var gratitudeItem in _gratitudeList)
        {
            Console.WriteLine($"- {gratitudeItem}");
        }
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}