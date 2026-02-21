class Address
{
    // --------- ATTRIBUTES ---------
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    
    // --------- CONSTRUCTOR ---------
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    
    // --------- GETTERS ---------
    public string GetFullText()
    {
        return (
            _street +"\n"+
            _city +", "+_state +", "+
            _country
        );
    }
}