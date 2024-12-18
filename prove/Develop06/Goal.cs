public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public string ShortName => _shortName;
    public string Description => _description;
    public int Points
    {
        get => _points;
        protected set => _points = value; // allows derived class to modify points
    }

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description}";
    }
    public abstract string GetStringRepresentation();
}