using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage ");
        string valueFromUser = Console.ReadLine();

        int g = int.Parse(valueFromUser);

        string letter = "";

        
        //takes the users grade percentage and displays to the user what letter
        //grade they got. 
        if (g >= 90)
        {
            letter = "A";
        }
        else if (g <= 89 && g >= 80)
        {
            letter = "B";
        }
        else if (g <= 79 && g >= 70)
        {
            letter = "C";
        }
        else if (g <= 69 && g >= 60)
        {
            letter = "D";
        }
        else if (g <= 59)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade: {letter}");

        //Displays to the user whether they passed or not.
        if (g >= 70)
        {
            Console.WriteLine("Congratualtions! You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass! Try again! You got this!");
        }
        
    }
}