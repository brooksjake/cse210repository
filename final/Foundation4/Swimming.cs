class Swimming : Activity
{
    // ----------- ATTRIBUTES -----------
    private int _laps;
    
    // ----------- CONSTRUCTOR -----------
    public Swimming(DateOnly date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    
    // ----------- METHODS -----------
    public override double GetDistance()
    {
        return _laps*50.0/1000.0*0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance()/GetMinutes())*60;
    }
    public override double GetPace()
    {
        return 60/GetSpeed();
    }
}