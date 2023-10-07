public class ReflectionActivity : Activity
{
    private int _randomQuestion;
    private List<string> _prompts = new List<string>();
    private List<NotRepeated> _questions = new List<NotRepeated>();


    public ReflectionActivity(string activityName, string description) :base(activityName, description)
    {
        _activityName = activityName;
        _description = description;
    }
    public void GetPromptFromFile()
    {
        string[] Lines = System.IO.File.ReadAllLines("ReflectionPrompts.txt");

        foreach (string line in Lines)
        {
            _prompts.Add(line);
        }
        
    }

    public void GetQuestionFromFile()
    {
        string[] Lines = System.IO.File.ReadAllLines("ReflectionQuestions.txt");

        foreach (string line in Lines)
        {
            string[] parts = line.Split("---");

            NotRepeated question = new NotRepeated(bool.Parse(parts[0]), parts[1]);
            _questions.Add(question);
        }
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count);
        string prompt = _prompts[randomNumber];

        return prompt;

    }

    public string GetRandomQuestion()
    {
        for (int i = 0; i < 1;)
        {
            Random random = new Random();
            _randomQuestion = random.Next(0, _questions.Count);

            if (_questions[_randomQuestion].GetHasBeenUsed() == false)
            {
                _questions[_randomQuestion].ChangeState();
                i++;
            }
        }

        return _questions[_randomQuestion].GetQuestion();
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        GetPromptFromFile();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have somthing in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        GetQuestionFromFile();
        
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(10);
        }

        Console.WriteLine();
        DisplayEndingMessage();
    }
}