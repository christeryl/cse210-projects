// Reception.cs
public class Reception : Event
{
    // Additional Properties
    private string RsvpEmail { get; set; }

    // Constructor
    public Reception(string eventTitle, string description, DateTime date, DateTime time, Address address, string rsvpEmail)
        : base(eventTitle, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    // Override the GetFullDetails method to include RSVP email
    public override string GetFullDetails()
    {
        string baseDetails = base.GetFullDetails();
        return $"{baseDetails}\nRSVP Email: {RsvpEmail}";
    }
}
