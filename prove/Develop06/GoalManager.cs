using System;
using System.Runtime.CompilerServices;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    // Add goal to list
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // Display goals
    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            string completionStatus = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{completionStatus} {goal.GetStringRepresentation()}");
        }
    }
    // Record event for a specific goal by name
    public void RecordGoal(string goalName)
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
                var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                _goals.Add(goal);
            }
        }
    }
}