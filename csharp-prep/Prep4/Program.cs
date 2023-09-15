using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNum = -1;
        while (userNum != 0)
        {
            Console.Write("Enter number: ");
            userNum = int.Parse(Console.ReadLine());

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }
        

        float sum = 0;
        float totalItems = 0;
        int greaterNumber = 0;
        foreach (int number in numbers)
        {
            sum += number;

            totalItems = totalItems + 1;

            if (number > greaterNumber)
            {
                greaterNumber = number;
            }
            
            
        }

        float average = sum / totalItems;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {greaterNumber}");
    }
}