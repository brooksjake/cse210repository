class Order
{
    private Customer _customer;
    private List<Product> _products;
    private double _domesticShippingCost = 5.00;
    private double _foreignShippingCost = 35.00;
    private double _totalCost;
    
    public Order(Customer customer)
    {
        _customer = customer;
        _totalCost = 0;
        _products = [];
    }
    
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    
    public double GetTotalCost()
    {
        foreach (Product p in _products)
        {
            _totalCost += p.GetUnitPrice() * p.GetQuantity();
        }
        
        if (_customer.IsForeigner())
        {
            _totalCost += _domesticShippingCost;
        } else
        {
            _totalCost += _foreignShippingCost;
        }
        
        return _totalCost;
    }
    
    public string GetPackingLabel()
    {
        string full = "   PACKING LABEL:\n";
        
        foreach (Product p in _products)
        {
            full += "#" + p.GetID() + " - " + p.GetProductName() + ", (quantity: " + p.GetQuantity() + ")";
            if (_products.IndexOf(p) != _products.Count-1) {full += "\n";}
        }
        
        return full;
    }
    
    public string GetShippingLabel()
    {
        return "   SHIPPING LABEL:\ncustomer - " + _customer.GetCustomerName() +"\n"+ _customer.GetAddress().GetFullText();
    }
}