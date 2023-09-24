using System;

class Program
{
    static void Main(string[] args)
    {
        string fileName;

        
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.ReadFromFile("prompts.txt");


        Console.WriteLine("Welcome to the Journal Program!");
        int selectedNum = 0;
        while (selectedNum != 5)
        {
            if (selectedNum > 5 || selectedNum < 0)
            {
                Console.WriteLine("!!Please select one of the option available on the menu!!");
            }

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            selectedNum = int.Parse(Console.ReadLine());

            if (selectedNum == 1)
            {
                DateTime currentDateTime = DateTime.Now;
                string formattedDateTime = currentDateTime.ToString("MM/dd/yyyy hh:mm tt");

                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write(">");
                string answer = Console.ReadLine();

                Entry entry1 = new Entry();
                entry1._date = formattedDateTime;
                entry1._prompt = prompt;
                entry1._userEntry = answer;

                journal.AddEntry(entry1, journal);
            }

            else if (selectedNum == 2)
            {
                journal.DisplayAll();
            }

            else if (selectedNum == 3)
            {
                Console.WriteLine("What is the file's name?");
                fileName = Console.ReadLine();
                journal.LoadFromFile(fileName); 
            }

            else if (selectedNum == 4)
            {
                Console.WriteLine("What is the file's name?");
                fileName = Console.ReadLine();
                journal.SaveToFile(journal._entries, fileName);
            }
        }
    }
}