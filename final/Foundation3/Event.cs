// Event.cs
public class Event
{
    // Properties
    private string EventTitle { get; set; }
    private string Description { get; set; }
    private DateTime Date { get; set; }
    private DateTime Time { get; set; }
    private Address EventAddress { get; set; }

    // Constructor
    public Event(string eventTitle, string description, DateTime date, DateTime time, Address address)
    {
        EventTitle = eventTitle;
        Description = description;
        Date = date;
        Time = time;
        EventAddress = address;
    }

    // Methods
    public string GetStandardDetails()
    {
        return $"Title: {EventTitle}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time.ToShortTimeString()}\nAddress: {GetAddressDetails()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {EventTitle}\nDate: {Date.ToShortDateString()}";
    }

    // Helper method to get address details
    private string GetAddressDetails()
    {
        return $"Street: {EventAddress.GetStreet()}\nCity: {EventAddress.GetCity()}\nState/Province: {EventAddress.GetStateProvince()}\nCountry: {EventAddress.GetCountry()}";
    }
}
