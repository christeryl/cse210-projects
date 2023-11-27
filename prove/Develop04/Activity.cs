using System;
using System.Threading;

class Activity
{
    protected int duration;
    protected DateTime startTime;

    public Activity(int duration)
    {
        this.duration = duration;
    }

    protected void ShowStartingMessage(string activityName, string description)
    {
        Console.WriteLine($"{activityName} - {description}");
        Console.WriteLine($"Please set the duration (seconds): {duration}");
        PauseWithSpinner(3);
        Console.WriteLine("Get ready to begin...");
        PauseWithSpinner(3);
        startTime = DateTime.Now;
    }

    protected void PauseWithSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowEndingMessage(string activityName)
    {
        Console.WriteLine($"Good job! You have completed the {activityName} activity.");
        Console.WriteLine($"Total time: {DateTime.Now.Subtract(startTime).TotalSeconds} seconds");
        PauseWithSpinner(5);
    }

    public virtual void Start()
    {

    }
}
