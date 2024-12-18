using System;

public class User
{
    private string _name;
    private int _level;
    private List<Goal> _goals;
    private List<string> _badges;

    public string Name => _name;
    public int Level => _level;

    public User(string name)
    {
        _name = name;
        _level = 1;
        _goals = new List<Goal>();
        _badges = new List<string>();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void AddBadge(string badge)
    {
        if (!_badges.Contains(badge))
        {
            _badges.Add(badge);
            Console.WriteLine($"New Badge Earned: {badge}");
        }
    }
    public void CalculateLevel(int totalPoints)
    {
        _level = totalPoints / 1000 + 1; // level up for every 1000 points
    }

    public void LoadData(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File {filename} not found.");
            return;
        }
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            string [] parts = line.Split(',');
            if (parts[0] == "SimpleGoal")
            {
                var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(goal);
            }
            else if (parts[0] == "EternalGoal")
            {
                var goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(goal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                _goals.Add(goal);
            }
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine($"Goals for {_name}: ");
        foreach (var goal in _goals)
        {
            string completionStatus = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{completionStatus} {goal.GetDetailsString()}");
        }
    }
    public void DisplayUserInfo()
    {
        Console.WriteLine($"User: {_name}, Level: {_level}");
        Console.WriteLine("Badges Earned: " + string.Join(", ", _badges));
    }
}