using System;

class Program
{
    static void Main(string[] args)
    {
        //I started initializing some object from my custom classes and created a fileName variable.
        string fileName;
        Menu menu = new Menu();
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.ReadFromFile("prompts.txt");

        //Here is where the program starts with a little message and a while loop so the user can interact
        //with the program until he no longer want it.
        Console.WriteLine("Welcome to the Journal Program!");
        int selectedNum = 0;
        while (selectedNum != 5)
        {
            //this is where I decided to indent some conditions using if statments so they can check which 
            //number from the menu the user wants to have access with.
            if (selectedNum > 5 || selectedNum < 0)
            {
                Console.WriteLine("!!Please select one of the option available on the menu!!");
            }

            menu.DisplayMenu();//here I called the DisplayMenu method from my Menu class.
            selectedNum = int.Parse(Console.ReadLine());
            
            
            if (selectedNum == 1)
            {
                //I decided to use the DateTime class for a easier manage to the time in my program.
                DateTime currentDateTime = DateTime.Now;
                string formattedDateTime = currentDateTime.ToString("MM/dd/yyyy hh:mm tt");//here I coverted from 
                //DateTime type to string avoiting erros later.


                //here, I called the GetRandomPrompt method from my PromptGenerator class so I can get a
                //random prompt from a string list.
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write(">");
                string answer = Console.ReadLine();

                //this is where a Entry object is going to be created every time the user picks the number 1 from
                //the menu.
                Entry entry1 = new Entry();
                entry1._date = formattedDateTime;
                entry1._prompt = prompt;
                entry1._userEntry = answer;

                journal.AddEntry(entry1);
            }

            else if (selectedNum == 2)
            {
                journal.DisplayAll();//Here I call the DisplayAll method from my Journal class and this method
                //is incharge of display the entry's information that is store in a list<Entry>
            }

            else if (selectedNum == 3)
            {
                Console.WriteLine("What is the file's name?");
                fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);//this method will read a file and stores the information 
                //obtained to a list. 
                Console.WriteLine("Your file has been loaded to the Journal!");
            }

            else if (selectedNum == 4)
            {
                Console.WriteLine("What is the file's name?");
                fileName = Console.ReadLine();
                journal.SaveToFile(journal._entries, fileName);//this method is incharge to save all the entries
                //objects to a file.
            }
        }
    }
}