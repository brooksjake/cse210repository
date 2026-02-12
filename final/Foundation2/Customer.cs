class Customer
{
    private string _customerName;
    private Address _address;
    
    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }
    
    public bool IsForeigner()
    {
        return _address.InUSA();
    }
    
    public string GetCustomerName()
    {
        return _customerName;
    }
    
    public Address GetAddress()
    {
        return _address;
    }
}