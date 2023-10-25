public class ProportionalityFunction : LinearFunctions
{
    private string _pFunction;



    public ProportionalityFunction()
    {
        
    }
    public ProportionalityFunction(string name, float y, float x, float m, string pFunction) : base(name, y, x, m)
    {
        _pFunction = pFunction;
    }

    public override void SetFunction(string function)
    {
        _pFunction = function;
    }

    public override void ValueTable(float mValue = 0, float nValue = 0, float aValue = 0, float bValue = 0, float cValue = 0, string operator1 = "", string operator2 = "")
    {
        List<int> xValues = new List<int>();

        Console.WriteLine("Please Select a serie of numbers to take the x value in the table. (Type done when your done.)");
        Console.WriteLine("The numbers selected can be negative or positive.");

        string userNumber = "none";
        while (userNumber != "done")
        {
            Console.Write("Enter number: ");
            userNumber = Console.ReadLine();

            if (userNumber == "done")
            {
                break;
            }
            else
            {
                xValues.Add(int.Parse(userNumber));
            }
        }
        Console.WriteLine();
        Console.Clear();
        Console.WriteLine("Value Table");
        Console.WriteLine(" X | Y ");
        Console.WriteLine("-------");

        //ProportionalityFunction pFunction = new ProportionalityFunction();


        foreach (int x in xValues)
        {
            SetY(mValue * x);

            if (x < 0)
            {
                Console.WriteLine($"{x} | {GetY()}");
            }
            else
            {
                Console.WriteLine($"{x}  |  {GetY()}");
            }

        }
        Console.WriteLine();
        Console.Write("Press enter to return the menu.");
        Console.ReadLine();
        Console.WriteLine();
    }

    public override string GetFunctionData()
    {
        return $"ProportionalFunction:{_pFunction}";
    }

}