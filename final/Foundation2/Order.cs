using System.Reflection;

public class Order
{
    private List<Product> _products;
    protected Customer _customer{get;set;}

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalCost();
        }
        // Adding shipping cost
        if (_customer.IsInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"Name: {product._name} ID: {product.productId}\n";
        }
        return label;
    }

}