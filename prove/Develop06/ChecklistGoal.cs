public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            Points += _bonus; // add bonus points when goal is complete
            Console.WriteLine($"Congrats!!! You completed your goal and earned {_bonus} bonus points!");
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()}, Completed {_amountCompleted}/{_target} times";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{ShortName}, {Description}, {Points}, {_amountCompleted}, {_target}, {_bonus}";
    }
}