using System;
using System.Collections.Generic;

public class Order
{
    // Private attributes
    private List<Product> products;
    private Customer customer;

    // Constructor
    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Method to calculate the total cost of the order
    public double GetTotalPrice()
    {
        double totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost
        totalCost += customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    // Method to get the packing label
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return packingLabel;
    }

    // Method to get the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetAddressString()}";
    }
}