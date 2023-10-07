using System;

class Program
{
    static void Main(string[] args)
    {
        int selectedNumber = 0;

        while (selectedNumber != 4)
        {
            Console.WriteLine("Menu options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. start Listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            selectedNumber = int.Parse(Console.ReadLine());

            if (selectedNumber > 4 || selectedNumber < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Please selec a valid option!!");
            }
            else if (selectedNumber == 1)
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", 
                "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.Run();
            }
            else if (selectedNumber == 2)
            {
                Console.Clear();
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", 
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectionActivity.Run();
            }
            else if (selectedNumber == 3)
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity("Listing Activity", 
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.Run();
            }
            else if (selectedNumber == 4)
            {
                break;
            }
        }
    }
}