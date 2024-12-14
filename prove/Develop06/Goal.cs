public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    
    // set to access the private fields
    public string ShortName => _shortName;
    public string Description => _description;
    public int Points => _points;

    public virtual void RecordEvent() { }
    public virtual bool IsComplete() {return false; }
    public virtual string GetDetailsString() {return ""; }
    public abstract string GetStringRepresentation();
}