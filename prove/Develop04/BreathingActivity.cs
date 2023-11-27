class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        ShowStartingMessage("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            PauseWithSpinner(3);

            if (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe out...");
                PauseWithSpinner(3);
            }
        }

        ShowEndingMessage("Breathing Activity");
    }
}
