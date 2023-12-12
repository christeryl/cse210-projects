// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Create an address
        Address eventAddress = new Address("123 Main St", "Cityville", "State", "Country");

        // Create instances of each event type
        Lecture lectureEvent = new Lecture("Interesting Lecture", "An informative session", DateTime.Now.Date, DateTime.Now.AddHours(2), eventAddress, "John Speaker", 100);
        Reception receptionEvent = new Reception("Networking Reception", "Casual networking event", DateTime.Now.Date.AddDays(7), DateTime.Now.AddHours(3), eventAddress, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Community Picnic", "A fun outdoor gathering", DateTime.Now.Date.AddDays(14), DateTime.Now.AddHours(4), eventAddress, "Sunny with a chance of clouds");

        // Call methods to generate marketing messages
        Console.WriteLine("Lecture Event:\n" + lectureEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + lectureEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + lectureEvent.GetShortDescription());

        Console.WriteLine("\n-----------------------------------\n");

        Console.WriteLine("Reception Event:\n" + receptionEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + receptionEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + receptionEvent.GetShortDescription());

        Console.WriteLine("\n-----------------------------------\n");

        Console.WriteLine("Outdoor Gathering Event:\n" + outdoorEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + outdoorEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + outdoorEvent.GetShortDescription());
    }
}
