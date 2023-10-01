using System;

class Program
{
    static void Main(string[] args)
    {
        // Here I created some objects from my References and Scripture classes.
        Reference reference = new Reference("John", 17, 3);
        Scripture scripture = new Scripture(reference, "And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent.");
    
        // Here is where I started a while loop to keep looping until the user type quit or all
        // the words are hidden.
        string user = "";
        while (user != "quit")
        {
            Console.Clear();
            scripture.IsCompletelyHidden();//this method will make sure all if all the words are
            //hidden.

            scripture.GetDisplayText();//this method displays the scripture.
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            user = Console.ReadLine();

            // this is statment is cheking if the words are hidden to end with the program.
            if (scripture.IsCompletelyHidden() == true && user == "")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }
        
        
    }
}