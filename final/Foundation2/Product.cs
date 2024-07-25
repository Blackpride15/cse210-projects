public class Product
{
    // Private attributes
    private string name;
    private string productId;
    private double price;
    private int quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Getter methods
    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }

    public double GetPrice()
    {
        return price;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    // Method to get total cost of the product
    public double GetTotalCost()
    {
        return price * quantity;
    }
}