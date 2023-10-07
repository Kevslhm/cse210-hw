using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> animationString = new List<string>();
        animationString.Add("o");
        animationString.Add("o");
        animationString.Add("o");
        animationString.Add("o");
        /* animationString.Add("o");
        animationString.Add("o");
        animationString.Add("o");
        animationString.Add("o"); */
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(8);

        int index = 0;
        int cycles = 1;
        while (DateTime.Now < endTime) 
        {
            if (index > 3)
            {
                index = 0;
                Console.Write("\b \b\b");
            }
            else if (cycles <= 4)
            {
                Console.Write(animationString[index]);
                Thread.Sleep(1000);
                //Console.Write("\b");
            }
            else if (cycles >= 5)
            {
                Console.Write(animationString[index]);
                Thread.Sleep(1000);
                Console.Write("\b \b\b");
            }
            cycles++;
            index++;
        }

        Console.WriteLine(" ");
    }
}