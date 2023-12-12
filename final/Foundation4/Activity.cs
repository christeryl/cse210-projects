using System;

public abstract class Activity
{
    private DateTime date;
    protected int length; // Change to protected to allow access in derived classes

    public Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }

    public virtual double GetDistance()
    {
        throw new NotImplementedException("GetDistance must be overridden in derived classes.");
    }

    public virtual double GetSpeed()
    {
        throw new NotImplementedException("GetSpeed must be overridden in derived classes.");
    }

    public virtual double GetPace()
    {
        throw new NotImplementedException("GetPace must be overridden in derived classes.");
    }

    public string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string summary = $"{date:dd MMM yyyy} {GetType().Name} ({length} min) - Distance: {distance:F2} miles, Speed: {speed:F2} mph, Pace: {pace:F2} min per mile";

        return summary;
    }
}