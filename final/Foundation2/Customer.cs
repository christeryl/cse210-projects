public class Customer
{
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Getter and setter for Name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Getter and setter for Address
    public Address Address
    {
        get { return address; }
        set { address = value; }
    }

    // Check if the customer lives in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    // Get the full address as a formatted string
    public string GetFullAddress()
    {
        return address.GetFullAddress();
    }
}
