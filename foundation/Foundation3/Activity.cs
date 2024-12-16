using System;

public abstract class Activity
{
    private DateTime _date;
    private int _length; // in minutes

    public DateTime Date => _date;
    public int Length => _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance(); // activities distance
    public abstract double GetSpeed(); // activities speed
    public abstract double GetPace(); // pace for activity
    // Method to call all other methods
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} - {GetType().Name} ({_length} min): " +
                $"Distance: {GetDistance():0.0} miles," +
                $"Speed: {GetSpeed():0.0} mph, " +
                $"Pace: {GetPace():0.0} min per mile";
    }
}