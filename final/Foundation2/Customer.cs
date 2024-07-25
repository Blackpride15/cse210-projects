public class Customer
{
    // Private attributes
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Getter methods
    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }

    // Method to check if customer lives in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}