public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded an event for the eternal goal: {Name}. You earned {Value} points.");
    }
}
