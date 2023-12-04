public class ChecklistGoal : Goal
{
    private int completedCount;
    private int targetCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        this.targetCount = targetCount;
    }

    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            completedCount++;
            Console.WriteLine($"You recorded an event for the checklist goal: {Name}. You earned {Value} points.");

            if (completedCount == targetCount)
            {
                IsCompleted = true;
                Console.WriteLine($"Congratulations! You completed the checklist goal: {Name}. Bonus: {Value} points.");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' has already been completed.");
        }
    }

    public string GetProgress()
    {
        return $"Completed {completedCount}/{targetCount} times";
    }
}
