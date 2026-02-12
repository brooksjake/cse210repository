class Product
{
    private string _productName;
    private int _productID;
    private double _unitPrice;
    private int _quantity;
    
    public Product(string name, int id, double unitPrice, int quantity)
    {
        _productName = name;
        _productID = id;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }
    
    public string GetProductName()
    {
        return _productName;
    }
    
    public int GetID()
    {
        return _productID;
    }
    
    public double GetUnitPrice()
    {
        return _unitPrice;
    }
    
    public int GetQuantity()
    {
        return _quantity;
    }
}