class ListingActivity : Activity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Count your many blessings. Name the one by one.",
        "Pretend you are at your favorite safe spaces. Where are they?",
        "What are the things you are looking forward to?"
    };

    public ListingActivity(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        ShowStartingMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        DateTime endTime = startTime.AddSeconds(duration);

        Random random = new Random();

        while (DateTime.Now < endTime)
        {
            string prompt = listingPrompts[random.Next(listingPrompts.Length)];
            Console.WriteLine(prompt);
            Console.WriteLine("Get ready to list items...");
            PauseWithSpinner(3);

            DateTime listStartTime = DateTime.Now;

            
            int itemCount = 0;
            while (DateTime.Now < endTime)
            {
                
                Console.WriteLine("Enter an item (or type 'done' to finish): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "done")
                {
                    break;
                }

                itemCount++;
            }

            Console.WriteLine($"Number of items entered: {itemCount}");
            PauseWithSpinner(3);

            if (DateTime.Now >= endTime)
            {
                break;
            }
        }

        ShowEndingMessage("Listing Activity");
    }
}
