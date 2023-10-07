public class ListingActivity : Activity
{
    private int _count;
    public List<string> _prompts = new List<string>();


    //this construtor will set some attributes that were inherit from the base class.
    public ListingActivity(string activityName, string description) : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;
    }


    //this methos will read information from a external file in which our listing prompts are stored.
     public void GetPromptFromFile()
    {
        string[] Lines = System.IO.File.ReadAllLines("ListingPrompts.txt");

        foreach (string line in Lines)
        {
            _prompts.Add(line);
        }
        
    }

    // this method will pick a random prompt from the _prompts list.
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count);
        string prompt = _prompts[randomNumber];

        Console.WriteLine($"--- {prompt} ---");

    }


    //this list method is here to store the user's responses in a temporal list and then 
    //couting how many responses the user could list.
    public List<string> GetListFromUser()
    {
        List<string> _userResponses = new List<string>();
        string userRespons;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            userRespons = Console.ReadLine();
            _userResponses.Add(userRespons);
        }
        _count = _userResponses.Count();
        return _userResponses;
    }


    //this run function will run the whole listing activity by displaying messages, animations, and prompts
    //to interact with the user.
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        GetPromptFromFile();
        Console.WriteLine();

        Console.WriteLine("List as many responses as you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        GetListFromUser();
        Console.WriteLine($"You have listed {_count} items!");

        Console.WriteLine();
        DisplayEndingMessage();

    }
}