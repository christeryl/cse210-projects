// Lecture.cs
public class Lecture : Event
{
    // Additional Properties
    private string SpeakerName { get; set; }
    private int Capacity { get; set; }

    // Constructor
    public Lecture(string eventTitle, string description, DateTime date, DateTime time, Address address, string speakerName, int capacity)
        : base(eventTitle, description, date, time, address)
    {
        SpeakerName = speakerName;
        Capacity = capacity;
    }

    // Override the GetFullDetails method to include speaker name and capacity
    public override string GetFullDetails()
    {
        string baseDetails = base.GetFullDetails();
        return $"{baseDetails}\nSpeaker Name: {SpeakerName}\nCapacity: {Capacity}";
    }
}
