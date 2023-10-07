public class Activity
{
    protected string _activityName;
    protected string _description;
    private int _duration;

    public Activity()
    {
        _activityName = "unknown";
        _description = "The description is empty by now.";
        _duration = 30;
    }

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public string GetName()
    {
        return _activityName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, Would like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
        ShowSpinner(5);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("―");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("―");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;

        int index = 0;
        while (DateTime.Now < endTime) 
        {
            if (index > 7)
            {
                index = 0;
            }

            Console.Write(animationString[index]);
            Thread.Sleep(250);
            Console.Write("\b");

            
            index++;
        }

        Console.WriteLine(" ");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            if (i >= 10)
            {
                Console.Write("\b\b  \b\b");
            }
            else
            {
                Console.Write("\b \b");
            }
        }
        Console.WriteLine(seconds.ToString(" "));
    }
}