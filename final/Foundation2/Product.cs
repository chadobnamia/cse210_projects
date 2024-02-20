public class Product
{
    internal object productId;

    public string _name{get; set;}
    protected string _productId{get;set;}
    private double _price{get;set;}
    private int _quantity{get;set;}

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
    
}
