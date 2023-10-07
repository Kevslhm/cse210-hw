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

    //this construtor will set two of our three attributes.
    //to manipulate them later on our main program.
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }
    //this method gets the activity's name
    public string GetName()
    {
        return _activityName;
    }


    //this method gets the activity's description.
    public string GetDescription()
    {
        return _description;
    }

    //this one gets the duration of our activity.
    public int GetDuration()
    {
        return _duration;
    }

    //this method will display a starting message whenever we call it
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, Would like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    //this one will display a end message whenever we call it.
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
        ShowSpinner(5);
        Console.Clear();
    }

    // the showspinner behavior wiil display on the screen a animation of a spinner.
    // we can also set the time we want to be on the screen
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
    // this method dislplay a countdown animation to the screen.
    //we can also set which number we want the countdown to start.
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