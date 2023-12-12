public class StationaryBicycle : Activity
{
    private double speed; // in miles per hour

    public StationaryBicycle(DateTime date, int length, double speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        // Speed (mph) = speed
        return speed;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = 60 / speed
        return 60 / speed;
    }

    public override double GetDistance()
    {
        // Implement a default distance calculation for StationaryBicycle.
        // You might want to return 0 or some default value depending on your application.
        return 0;
    }
}