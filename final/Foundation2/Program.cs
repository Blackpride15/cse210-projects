using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "City1", "State1", "USA");
        Address address2 = new Address("456 Elm St", "City2", "State2", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Product1", "P001", 10.0, 2);
        Product product2 = new Product("Product2", "P002", 20.0, 1);
        Product product3 = new Product("Product3", "P003", 15.0, 3);
        Product product4 = new Product("Product4", "P004", 30.0, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Store orders in a list
        List<Order> orders = new List<Order> { order1, order2 };

        // Display order information
        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice()}\n");
        }
    }
}