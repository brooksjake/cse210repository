class Cycling : Activity
{
    // ----------- ATTRIBUTES -----------
    private double _speedMph;
    
    // ----------- CONSTRUCTOR -----------
    public Cycling(DateOnly date, int minutes, double speedMph) : base(date, minutes)
    {
        _speedMph = speedMph;
    }
    
    // ----------- METHODS -----------
    public override double GetDistance()
    {
        return (_speedMph*GetMinutes())/60;
    }
    public override double GetSpeed()
    {
        return _speedMph;
    }
    public override double GetPace()
    {
        return 60/_speedMph;
    }
}