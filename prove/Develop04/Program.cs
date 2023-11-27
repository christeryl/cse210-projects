using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            int choice = GetValidChoice(1, 4);

            if (choice == 4)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }

            Console.WriteLine("Enter the duration in seconds:");
            int duration = GetValidDuration();

            Activity activity;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity(duration);
                    break;
                case 2:
                    activity = new ReflectionActivity(duration);
                    break;
                case 3:
                    activity = new ListingActivity(duration);
                    break;
                default:
                    throw new InvalidOperationException("Invalid choice");
            }

            activity.Start();
        }
    }

    static int GetValidChoice(int min, int max)
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < min || choice > max)
        {
            Console.WriteLine($"Please enter a valid choice between {min} and {max}:");
        }
        return choice;
    }

    static int GetValidDuration()
    {
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.WriteLine("Please enter a valid duration (greater than 0):");
        }
        return duration;
    }
}
