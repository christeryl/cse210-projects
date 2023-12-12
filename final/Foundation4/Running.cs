public class Running : Activity
{
    private double distance; // in miles

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        // Speed (mph) = (distance / minutes) * 60
        return (distance / length) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = minutes / distance
        return length / distance;
    }
}