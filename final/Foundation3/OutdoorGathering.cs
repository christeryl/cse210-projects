// OutdoorGathering.cs
public class OutdoorGathering : Event
{
    // Additional Properties
    private string WeatherForecast { get; set; }

    // Constructor
    public OutdoorGathering(string eventTitle, string description, DateTime date, DateTime time, Address address, string weatherForecast)
        : base(eventTitle, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    // Override the GetFullDetails method to include weather forecast
    public override string GetFullDetails()
    {
        string baseDetails = base.GetFullDetails();
        return $"{baseDetails}\nWeather Forecast: {WeatherForecast}";
    }
}
