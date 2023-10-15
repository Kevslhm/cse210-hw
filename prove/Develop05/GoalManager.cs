using System.Linq.Expressions;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        int goalChoice;
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine($"1. Create New Goal");
            Console.WriteLine($"2. List Goals");
            Console.WriteLine($"3. Save Goals");
            Console.WriteLine($"4. Load Goals");
            Console.WriteLine($"5. Record Event");
            Console.WriteLine($"6. Quit");
            Console.Write("Select a choice from the Menu: ");
            choice = int.Parse(Console.ReadLine());  

            if (choice == 1)
            {
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of Goal you like to create? ");
                goalChoice = int.Parse(Console.ReadLine());


                if (goalChoice == 1)
                {
                    CreateGoal(goalChoice);
                }
                else if (goalChoice == 2)
                {
                    CreateGoal(goalChoice);
                }
                else if (goalChoice == 3)
                {
                    CreateGoal(goalChoice);
                }
            }
            else if (choice == 2)
            {
                if (_goals.Count() == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, the List is empty by now! Pleas try to load a file to the program.");
                    Console.Write("Press enter to return the menu.");
                    Console.ReadLine();
                }
                else if (_goals.Count() > 0)
                {
                    Console.WriteLine("The goals added to the list are: "); 

                    ListGoalDetails();
                    Console.WriteLine();
                }
               
            }
            else if (choice == 3)
            {
                Console.Write("What is the file's name? ");
                string fileName = Console.ReadLine();

                ShowSavingAnimation();

                SaveGoals(fileName);
            } 
            else if (choice == 4)
            {
                Console.Write("What is the file's name? ");
                string fileName = Console.ReadLine();

                ShowLoadingAnimation();
                
                LoadGoals(fileName);
                Console.WriteLine();
            } 
            else if (choice == 5)
            {
                ListGoalNames();
                RecordEvent();
            } 
            else if (choice == 6)
            {
                break;
            }           

        }
    }

    
    public void CreateGoal(int userchoice)
    {
        if (userchoice == 1)
        {
            Console.Write("What is the name of the Goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is the description? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, 0, false);
            _goals.Add(simpleGoal);
        }
        else if (userchoice == 2)
        {
            Console.Write("What is the name of the Goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is the description? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints, 0);
            _goals.Add(eternalGoal);
        }
        else if (userchoice == 3)
        {
             Console.Write("What is the name of the Goal? ");
             string goalName = Console.ReadLine();
             Console.Write("What is the description? ");
             string goalDescription = Console.ReadLine();
             Console.Write("What is the amount of points associated with this goal? ");
             int goalPoints = int.Parse(Console.ReadLine());
             Console.Write("How many times does this goal need to be accoplished for a bonus? ");
             int goalTarget = int.Parse(Console.ReadLine());
             Console.Write("What is the bonus for accomplishing it that many times? ");
             int goalBonus = int.Parse(Console.ReadLine());

             ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus, 0);
             _goals.Add(checklistGoal);
        }
    }


    public void ListGoalDetails()
    {
        int listNumber = 1;
            foreach (Goal g in _goals)
            {
                if (g.IsComplete() == true)
                {
                    g.SetCheckbox("[x]");
                }

                Console.WriteLine($"{listNumber}. {g.GetDetailString()}");
                listNumber++;
            }
    }

    public void ListGoalNames()
    {
        int listNumber = 1;

        Console.WriteLine("The goals are: ");
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{listNumber}. {g.GetGoalName()}");
            listNumber++;
        }
    }

    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine());

        _goals[index -1].RecordEvent();

        if (_goals[index - 1].IsComplete() == true && _goals[index - 1].GetBonus() > 0)
        {
            _score = _score + _goals[index - 1].GetBonus();
            Console.WriteLine($"Congratulations! You have earned a bonus of {_goals[index - 1].GetBonus()} points!");
        }
        else
        {
            _score = _score + _goals[index - 1].GetPoints();
            Console.WriteLine($"Congratulations! You have earned {_goals[index - 1].GetPoints()} points!");
        }

        
        Console.WriteLine($"You now have {_score}");
        Console.WriteLine();
        
    }

    public void SaveGoals(string fileName)
    {
        using(StreamWriter goalWriter = new StreamWriter(fileName))
        {
            goalWriter.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                goalWriter.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);

        foreach (string line in lines)
        {
            string[] parts = line.Split(':', ',');

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), bool.Parse(parts[5]));
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                _goals.Add(eternalGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]), int.Parse(parts[6]));
                _goals.Add(checklistGoal);
            }
        }
    }


    public void ShowLoadingAnimation()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(6);

        Console.Clear();
        Console.Write("Loading ");

        int cycle  = 0;
        while (DateTime.Now < endTime)
        {
            cycle++;

            if (cycle <= 4)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            else
            {
                Console.Write("\b\b\b\b    \b\b\b\b");
                cycle = 0;
            }
            
        }

        Console.Clear();
        Console.WriteLine("The document has been succesfuly loaded!!");
        Console.Write("Press enter to go back to the menu!");
        Console.ReadLine();


    }
    

    public void ShowSavingAnimation()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(6);

        Console.Clear();
        Console.Write("Saving ");

        int cycle  = 0;
        while (DateTime.Now < endTime)
        {
            cycle++;

            if (cycle <= 4)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            else
            {
                Console.Write("\b\b\b\b    \b\b\b\b");
                cycle = 0;
            }
            
        }

        Console.Clear();
        Console.WriteLine("The document has been succesfuly saved!!");
        Console.Write("Press enter to go back to the menu!");
        Console.ReadLine();


    }
}