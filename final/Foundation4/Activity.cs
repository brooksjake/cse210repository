abstract class Activity
{
    // ----------- ATTRIBUTES -----------
    private DateOnly _datePerformed;
    private double _minutes; // i have minutes as a double because what if you're trying to track exercise records down to part of a minute?
    private string _activityType;
    
    
    // ----------- CONSTRUCTOR -----------
    public Activity(DateOnly date, double minutes)
    {
        _datePerformed = date;_minutes = minutes;
        _activityType = GetType().Name;
    }
    
    // ----------- METHODS -----------
    public string GetSummary()
    {
        return $"{_datePerformed.ToString("dd MMM yyyy")} {_activityType} ({_minutes} min): Distance {GetDistance():0.0}miles, Speed {GetSpeed():0.0}mph, Pace {GetPace():0.0} min per mile";
    }
    
    public double GetMinutes()
    {
        return _minutes;
    }
    
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}