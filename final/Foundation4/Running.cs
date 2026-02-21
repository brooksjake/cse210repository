class Running : Activity
{
    // ----------- ATTRIBUTES -----------
    private double _distance;
    
    // ----------- CONSTRUCTOR -----------
    public Running(DateOnly date, double minutes, double miles) : base(date, minutes)
    {
        _distance = miles;
    }
    
    // ----------- METHODS -----------
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance/GetMinutes())*60;
    }
    public override double GetPace()
    {
        return GetMinutes()/_distance;
    }
}