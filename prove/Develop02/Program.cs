using System;

class Program
{
    static void Main(string[] args)
    {
         Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save the Journal to a File");
            Console.WriteLine("4. Load the Journal from a File");
            Console.WriteLine("5. Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = promptGenerator.GetPrompt();
                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Enter your response: ");
                    string entryText = Console.ReadLine();
                    Entry entry = new Entry($"{randomPrompt} - {entryText}", DateTime.Now);
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter the file name to save the journal: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveJournal(saveFileName);
                    break;

                case "4":
                    Console.Write("Enter the file name to load the journal: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadJournal(loadFileName);
                    break;

                case "5":
                    Console.WriteLine("Quitting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}

class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayEntries()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveJournal(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}| {entry.Text}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadJournal(string fileName)
    {
        if (File.Exists(fileName))
        {
            entries.Clear(); // Clear existing entries before loading from the file

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(new[] { '|' }, 2);
                    if (parts.Length == 2)
                    {
                        DateTime date;
                        if (DateTime.TryParse(parts[0], out date))
                        {
                            Entry entry = new Entry(parts[1], date);
                            entries.Add(entry);
                        }
                    }
                }
            }

            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine($"File '{fileName}' not found.");
        }
    }
}

class Entry
{
    public string Text { get; }
    public DateTime Date { get; }

    public Entry(string text, DateTime date)
    {
        Text = text;
        Date = date;
    }

    public void Display()
    {
        Console.WriteLine($"{Date}: {Text}");
    }
}

class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Did anything exciting happen today?",
        "What was your biggest challenge today?",
        "What was your biggest victory today?",
        "Did you help anyone today?",
        "If I had more time to do something today, I would...",
        "What did you learn today?",
        "What made you smile today?",
        "How can you make tomorrow great?",
        "What tasks need to be completed for tomorrow?",
        "Did you do your best? Explain. If not, how can you do better?",
        "Write a positive affirmation for yourself today.",
        "What form of self care did you do/will you do today?",
        "How can I grow closer to Heavenly Father today?"
    };

    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}