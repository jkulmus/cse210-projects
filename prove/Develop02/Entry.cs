using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;
    private string _mood; // new field for mood
    private List<string> _tags; // added for tags

    public Entry(string date, string promptText, string entryText, string mood, List<string>tags)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _mood = mood;
        _tags = tags ?? new List<string>();
    }

    // Properties for accessing fields
    public string DisplayDate => _date;
    public string DisplayPrompt => _promptText; 
    public string DisplayText => _entryText;
    public string DisplayMood => _mood;
    public string DisplayTags => string.Join(",", _tags);

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Tags: {DisplayTags}");
        Console.WriteLine(); // added for spacing
    }
}