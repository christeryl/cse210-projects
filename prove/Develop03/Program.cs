using System;

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        
        do
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n"); //used in place of Console.Clear(); because it kept throwing errors at me

            scripture.Display();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        } while (!scripture.AllWordsHidden());
    }
}