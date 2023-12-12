public class Swimming : Activity
{
    private int laps; // number of laps

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        // Distance (miles) = laps * 50 / 1000 * 0.62
        return laps * 50.0 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        // Speed (mph) = (distance / minutes) * 60
        return (GetDistance() / length) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = minutes / distance
        return length / GetDistance();
    }
}
