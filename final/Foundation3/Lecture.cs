class Lecture : Event
{
    // --------- ATTRIBUTES ---------
    private string _speakerName;
    private int _capacity;
    
    // --------- CONSTRUCTOR ---------
    public Lecture(string title, string description, DateOnly date, TimeOnly time, Address address, string speakerName, int capacity) : base(title, description, date, time, address)
    {
        _speakerName = speakerName; _capacity = capacity;
    }
    
    // --------- DISPLAYERS ---------
    public override void DisplayFullDetails()
    {
        // first display all the normal event stuff
        base.DisplayFullDetails();
        // now the lecture specific details
        Console.WriteLine($"Speaker: {_speakerName}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
    
    // --------- SETTERS ---------
    public void SetSpeakerName(string speakerName)
    {
        _speakerName = speakerName;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }
    
    // --------- GETTERS ---------
    public string GetSpeakerName()
    {
        return _speakerName;
    }

    public int GetCapacity()
    {
        return _capacity;
    }
}