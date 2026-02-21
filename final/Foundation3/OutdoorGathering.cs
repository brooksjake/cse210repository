class OutdoorGathering : Event
{
    // --------- ATTRIBUTES ---------
    private string _weatherForecast;
    
    // --------- CONSTRUCTOR ---------
    public OutdoorGathering(string title, string description, DateOnly date, TimeOnly time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }
    
    // --------- DISPLAYERS ---------
    public override void DisplayFullDetails()
    {
        // first display all the normal event stuff
        base.DisplayFullDetails();
        // now the outdoorgathering specific details
        Console.WriteLine($"Weather Forecast: {_weatherForecast}");
    }
    
    // --------- SETTERS ---------
    public void SetWeatherForecast(string weatherForecast)
    {
        _weatherForecast = weatherForecast;
    }
    
    // --------- GETTERS ---------
    public string GetWeatherForecast()
    {
        return _weatherForecast;
    }
}