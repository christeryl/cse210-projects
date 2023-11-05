using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();

        string userName = UserName();
        int userNumber = UserNumber();

        int squaredNumber = SquaredNumber(userNumber);

        NameAndSquaredNumber(userName, squaredNumber);
    }

    static void Welcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserName()
    {
        Console.Write("Enter your name! ");
        string name = Console.ReadLine();
        return name;
    }

    static int UserNumber()
    {
        Console.Write("Enter your favorite number! ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }


    static int SquaredNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void NameAndSquaredNumber(string name, int square)
    {
      Console.WriteLine($"{name}, the square of your numbere is {square}!");  
    }
}