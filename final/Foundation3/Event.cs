
class Event
{
    private string _title;
    private string _description;
    private string _eventType;
    private DateOnly _date;
    private TimeOnly _time;
    private Address _address;
    
    
    // --------- CONSTRUCTOR ---------
    public Event(string title, string description, DateOnly date, TimeOnly time, Address address)
    {
        _title = title; _description = description;
        _eventType = GetType().Name;
        _date = date; _time = time; _address = address;
    }
    
    
    // --------- DISPLAYERS ---------
    public void DisplayStandardDetails()
    {
        Console.WriteLine($"-- STANDARD Details --");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date.ToString("D")}"); 
        Console.WriteLine($"Time: {_time.ToString("t")}");
        Console.WriteLine($"Location: {_address.GetFullText()}");
    }
    
    public virtual void DisplayFullDetails()
    {
        Console.WriteLine($"-- FULL Details --");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date.ToString("D")}"); 
        Console.WriteLine($"Time: {_time.ToString("t")}");
        Console.WriteLine($"Location: {_address.GetFullText()}");
        Console.WriteLine($"Type: {_eventType}");
    }
    
    public void DisplayShortDetails()
    {
        Console.WriteLine($"-- SHORT Details --");
        Console.WriteLine($"Type: {_eventType}");
        Console.WriteLine($"Date: {_date.ToString("D")}"); 
        Console.WriteLine($"Time: {_time.ToString("t")}");
    }
    
    
    // --------- SETTERS ---------
    public void setTitle(string title)
    {
        _title = title;
    }
    
    public void setDescription(string description)
    {
        _description = description;
    }
    
    public void setDate(DateOnly date)
    {
        _date = date;
    }
    public void setTime(TimeOnly time)
    {
        _time = time;
    }
    
    public void setAddress(Address address)
    {
        _address = address;
    }
    
    
    // --------- GETTERS ---------
    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public DateOnly GetDate()
    {
        return _date;
    }

    public TimeOnly GetTime()
    {
        return _time;
    }

    public Address GetAddress()
    {
        return _address;
    }
    
}