using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create instances of different activities
        Running runningActivity = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        StationaryBicycle bikeActivity = new StationaryBicycle(new DateTime(2022, 11, 3), 30, 15.0);
        Swimming swimmingActivity = new Swimming(new DateTime(2022, 11, 3), 30, 20);

        // Add activities to a list
        List<Activity> activities = new List<Activity>
        {
            runningActivity,
            bikeActivity,
            swimmingActivity
        };

        // Display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
