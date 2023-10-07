public class ListingActivity : Activity
{
    private int _count;
    public List<string> _prompts = new List<string>();

    public ListingActivity(string activityName, string description) : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;
    }

     public void GetPromptFromFile()
    {
        string[] Lines = System.IO.File.ReadAllLines("ListingPrompts.txt");

        foreach (string line in Lines)
        {
            _prompts.Add(line);
        }
        
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count);
        string prompt = _prompts[randomNumber];

        Console.WriteLine($"--- {prompt} ---");

    }

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

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        GetPromptFromFile();
        Console.WriteLine();

        Console.WriteLine("List as many responses as you canto the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        GetListFromUser();
        Console.WriteLine($"You have listed {_count} items!");

        Console.WriteLine();
        DisplayEndingMessage();

    }
}