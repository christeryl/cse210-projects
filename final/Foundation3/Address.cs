// Address.cs

public class Address
{
    // Properties
    private string Street { get; set; }
    private string City { get; set; }
    private string StateProvince { get; set; }
    private string Country { get; set; }

    // Constructor
    public Address(string street, string city, string stateProvince, string country)
    {
        Street = street;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    // Getters and Setters
    public string GetStreet()
    {
        return Street;
    }

    public void SetStreet(string street)
    {
        Street = street;
    }

    public string GetCity()
    {
        return City;
    }

    public void SetCity(string city)
    {
        City = city;
    }

    public string GetStateProvince()
    {
        return StateProvince;
    }

    public void SetStateProvince(string stateProvince)
    {
        StateProvince = stateProvince;
    }

    public string GetCountry()
    {
        return Country;
    }

    public void SetCountry(string country)
    {
        Country = country;
    }
}
