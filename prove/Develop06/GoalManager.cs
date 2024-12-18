using System;


public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public int TotalPoints()
    {
        return _goals.Sum(goal => goal.Points);
    }
    public void Start()
    { // implement main logic
        DisplayPlayerInfo();
        ListGoalDetails();
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }
    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    // Display goals
    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            string completionStatus = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"goal.GetStringRepresentation()");
        }
    }
    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    // Record event for a specific goal by name
    public void RecordEvent(string goalName)
    {
        Goal goal = _goals.FirstOrDefault(g => g.ShortName == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            _score += goal.Points;
        }
    }
    // Save to files
    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    // Load goals
    public void LoadGoals()
    {
        string[] lines = File.ReadAllLines("goals.txt");
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
}