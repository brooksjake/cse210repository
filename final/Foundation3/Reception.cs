class Reception : Event
{
    // --------- ATTRIBUTES ---------
    private string _rsvpMessage;
    
    // --------- CONSTRUCTOR ---------
    public Reception(string title, string description, DateOnly date, TimeOnly time, Address address, string rsvpMessage) : base(title, description, date, time, address)
    {
        _rsvpMessage = rsvpMessage;
    }
    
    // --------- DISPLAYERS ---------
    public override void DisplayFullDetails()
    {
        // first display all the normal event stuff
        base.DisplayFullDetails();
        // now the reception specific details
        Console.WriteLine($"RSVP message: {_rsvpMessage}");
    }
    
    // --------- SETTERS ---------
    public void SetRsvpMessage(string rsvpMessage)
    {
        _rsvpMessage = rsvpMessage;
    }
    
    // --------- GETTERS ---------
    public string GetRsvpMessage()
    {
        return _rsvpMessage;
    }
}