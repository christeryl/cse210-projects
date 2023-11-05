using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List <int>();

        //Find the numbers added up
        int usernum = -1;
        while (usernum != 0)
        {
            Console.Write("Enter numbers. When you are done, press 0. ");

            string userinput = Console.ReadLine();
            usernum = int.Parse(userinput);

            if (usernum != 0)
            {
                numbers.Add(usernum);
            }
        }
        int sum = 0;
        
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The list added up equals {sum}.");

        //Find the average of the list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the inputs is {average}.");

        //Find the max value of the list

        int maxnum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxnum)
            {
                maxnum = number;
            }
        }
        Console.WriteLine($"The max number is {maxnum}");
    }
}