using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string strGrade = Console.ReadLine();
        int userGrade = int.Parse(strGrade);

        string letter = "";

        if (userGrade >= 90)
        {
            letter = "A";
        }

        else if (userGrade >= 80)
        {
            letter = "B";
        }

        else if (userGrade >= 70)
        {
            letter = "C";
        }

        else if (userGrade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (userGrade >= 70)
        {
            Console.WriteLine("Congratulation!! You have passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you will get it next time.");
        }
    }
}