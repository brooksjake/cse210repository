class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateOrProvince;
        _country = country;
    }
    
    public bool InUSA()
    {
        return _country.ToUpper() == "USA";
    }
    
    public string GetFullText()
    {
        return (
            _streetAddress +"\n"+
            _city +", "+_stateProvince +", "+
            _country
        );
    }
}