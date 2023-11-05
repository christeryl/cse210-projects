using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnum = randomGenerator.Next(1, 101);

        int guess = 0;

        while (guess != magicnum)
        {
            Console.Write("Guess a number! ");
            guess = int.Parse(Console.ReadLine());

            if(magicnum > guess)
            {
                Console.WriteLine("Higher!");
            }
            else if (magicnum < guess)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("Whoo! You got it!");
            }
        }
    }
}