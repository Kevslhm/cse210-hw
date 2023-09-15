using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();

        string name = PromptUserName();

        int userNumber = PromptNumber();

        int squaredNum = SquaredNumber(userNumber);

        DisplayResult(name, squaredNum);
        

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }


        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }


        static int PromptNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favNumber = int.Parse(Console.ReadLine());
            return favNumber;
        }


        static int SquaredNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }


        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }


    }
}