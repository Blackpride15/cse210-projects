public class Address
{
    // Private attributes
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    // Constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Method to check if address is in the USA
    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    // Method to get address as a string
    public string GetAddressString()
    {
        return $"{streetAddress}\n{city}, {state}\n{country}";
    }
}