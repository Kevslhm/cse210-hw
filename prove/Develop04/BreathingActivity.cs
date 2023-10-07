using System.Text;

public class BreathingActivity : Activity
{
    //this constructor will set the activity name and the description by inherit some attributes from
    // the base class "Activity".
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;
    }

    //the run method is incharged of run the whole breathing activity by displaying some messages and so animations
    //to the terminal.
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Breath in...");
        ShowCountDown(2);
        Console.Write("Now breath out...");
        ShowCountDown(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.Write("Now breath out...");
            ShowCountDown(6);
        }

        Console.WriteLine();
        DisplayEndingMessage();
    }
}