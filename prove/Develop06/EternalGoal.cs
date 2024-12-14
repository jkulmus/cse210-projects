public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }
    public override void RecordEvent()
    {
        // Eternal goals are never done
    }
    public override bool IsComplete()
    {
        return false; //eternal is never finished
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {_shortName}, {_description}, {_points}";
    }
}