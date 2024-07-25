class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Elm St", "Austin", "TX", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Alex Johnson", address1);
        Customer customer2 = new Customer("Mia Davis", address2);

        Product product1 = new Product("The Hobbit Book - Box Set", 412, 149.59, 1);
        Product product2 = new Product("Samsung Galaxy Laptop", 652, 2499.89, 1);
        Product product3 = new Product("Mechanical Keyboard", 106, 69.29, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product2);

        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Shipping Cost: ${order1.GetShippingCost():0.00}");
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Shipping Cost: ${order2.GetShippingCost():0.00}");
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
        Console.WriteLine();
    }
}