class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "Would you ever do this again?",
        "How did this experience affect you?"
    };

    public ReflectionActivity(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        ShowStartingMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        DateTime endTime = startTime.AddSeconds(duration);

        Random random = new Random();

        while (DateTime.Now < endTime)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            PauseWithSpinner(10);

            foreach (var question in reflectionQuestions)
            {
                Console.WriteLine(question);
                PauseWithSpinner(10);

                if (DateTime.Now >= endTime)
                {
                    break;
                }
            }

            if (DateTime.Now >= endTime)
            {
                break;
            }
        }

        ShowEndingMessage("Reflection Activity");
    }
}
