public class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    // Constructor
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    // Getter and setter for StreetAddress
    public string StreetAddress
    {
        get { return streetAddress; }
        set { streetAddress = value; }
    }

    // Getter and setter for City
    public string City
    {
        get { return city; }
        set { city = value; }
    }

    // Getter and setter for StateProvince
    public string StateProvince
    {
        get { return stateProvince; }
        set { stateProvince = value; }
    }

    // Getter and setter for Country
    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    // Check if the address is in the USA
    public bool IsInUSA()
    {
        // Assuming the country code for the USA is "USA"
        return country.ToUpper() == "USA";
    }

    // Get the full address as a formatted string
    public string GetFullAddress()
    {
        return $"Address: {streetAddress}, {city}, {stateProvince}, {country}";
    }
}
